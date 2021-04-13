﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.Windows;
namespace AGU2lab
{
    public class Game : IDisposable
    {
        RenderForm _renderForm;

        MeshObject _cube;
        MeshObject _axis;
        Camera _camera;

        DirectX3DGraphics _directX3DGraphics;
        Renderer _renderer;

        TimeHelper _timeHelper;

        public Game()
        {
            _renderForm = new RenderForm();
            _renderForm.UserResized += RenderFormResizedCallback;
            _directX3DGraphics = new DirectX3DGraphics(_renderForm);
            _renderer = new Renderer(_directX3DGraphics);
            _renderer.CreateConstantBuffers();

            Loader loader = new Loader(_directX3DGraphics);
            _cube = loader.MakeCubeocthaedr(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), 0.0f,
            0.0f, 0.0f);
            _axis = loader.MakeAxis(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), 0.0f,
            0.0f, 0.0f);
            _camera = new Camera(new Vector4(0.0f, 2.0f, -10.0f, 1.0f));
            _timeHelper = new TimeHelper();
            loader.Dispose();
            loader = null;
        }

        public void RenderFormResizedCallback(object sender, EventArgs args)
        {
            _directX3DGraphics.Resize();
            _camera.Aspect = _renderForm.ClientSize.Width /
            (float)_renderForm.ClientSize.Height;
        }

        private bool _firstRun = true;

        public void RenderLoopCallback()
        {
            if (_firstRun)
            {
                RenderFormResizedCallback(this, EventArgs.Empty);
                _firstRun = false;
            }
            _timeHelper.Update();
            _renderForm.Text = "FPS: " + _timeHelper.FPS.ToString();
            _cube.YawBy(_timeHelper.DeltaT * MathUtil.TwoPi * 0.1f);

            Matrix viewMatrix = _camera.GetViewMatrix();
            Matrix projectionMatrix = _camera.GetProjectionMatrix();


            _renderer.BeginRender();

            _renderer.SetPerObjectConstantBuffer(_timeHelper.Time, 1);

            _renderer.UpdatePerObjectConstantBuffers(_cube.GetWorldMatrix(),
            viewMatrix, projectionMatrix);
            _renderer.RenderMeshObject(_cube);
            _renderer.UpdatePerObjectConstantBuffers(_axis.GetWorldMatrix(),
            viewMatrix, projectionMatrix);
            _renderer.RenderMeshObject(_axis);
            _renderer.EndRender();
        }

        public void Run()
        {
            RenderLoop.Run(_renderForm, RenderLoopCallback);
        }

        public void Dispose()
        {
            _cube.Dispose();
            _axis.Dispose();
            _renderer.Dispose();
            _directX3DGraphics.Dispose();
        }
    }
}