
// Copyright (C) 2012-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// State tracking the transformation state (single-precision implementation).
	/// </summary>
	[DebuggerDisplay("TransformState LocalModel={LocalModel} LocalProjection={LocalProjection} LocalModel={LocalModel}")]
	public class TransformState : TransformStateBase
	{
		#region Constructors

		/// <summary>
		/// Default TransformStateSingle.
		/// </summary>
		public TransformState()
		{

		}

		/// <summary>
		/// Construct the current TransformStateSingle (compatibility profile only).
		/// </summary>
		public TransformState(GraphicsContext ctx)
		{

		}

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for TransformState.
		/// </summary>
		public static TransformState DefaultState { get { return (new TransformState()); } }

		#endregion

		#region TransformStateBase Overrides

		/// <summary>
		/// The local model matrix. Transform object-space to universe-space. This property has a lazy initialization: if
		/// not accessed, no model matrix is defined.
		/// </summary>
		public override IModelMatrix LocalModel { get { return (_LocalModel ?? (_LocalModel = new ModelMatrix())); } }

		/// <summary>
		/// Utility routine for checking the actual definition of LocalModel, without triggering the lazy initialization.
		/// </summary>
		protected override bool HasLocalModel { get { return (_LocalModel != null); } }

		/// <summary>
		/// The local model-view matrix of this state.
		/// </summary>
		private ModelMatrix _LocalModel;

		/// <summary>
		/// The local projection: the projection matrix used for defining <see cref="LocalModelViewProjection"/>.
		/// </summary>
		public override IProjectionMatrix LocalProjection
		{
			get { return (_LocalProjection); }
			set
			{
				if (value != null) {
					ProjectionMatrix projectionMatrix = value.Clone() as ProjectionMatrix;
					if (projectionMatrix == null)
						throw new InvalidOperationException("value is not ProjectionMatrix");
					_LocalProjection = projectionMatrix;
				} else
					_LocalProjection = null;
			}
		}

		/// <summary>
		///  The local projection matrix of this state.
		/// </summary>
		private ProjectionMatrix _LocalProjection;

		/// <summary>
		/// Get or set the combined model-view matrix. This property defaults to null. It must be set manually to have a
		/// meaninful value.
		/// </summary>
		public override IModelMatrix LocalModelView
		{
			get { return (_LocalModelView); }
			set
			{
				if (value != null) {
					ModelMatrix modelviewMatrix = value.Clone() as ModelMatrix;
					if (modelviewMatrix == null)
						throw new InvalidOperationException("value is not ModelMatrix");
					_LocalModelView = modelviewMatrix;
				} else
					_LocalModelView = null;
			}
		}

		/// <summary>
		/// The local model-view matrix of this state.
		/// </summary>
		private ModelMatrix _LocalModelView;

		/// <summary>
		/// Get the combined model-view-projection matrix. This property has a lazy initialization: if not accessed, no
		/// model-view-projection matrix is defined. To automatically initialize this property without exception, the
		/// <see cref="LocalProjection"/> and <see cref="LocalModelView"/> must be defined. It is possible to set
		/// manually this property: doing so it will return a copy of the value.
		/// </summary>
		public override IModelMatrix LocalModelViewProjection
		{
			get
			{
				if (_LocalModelViewProjection == null) {
					if (_LocalModelView == null || _LocalProjection == null)
						throw new InvalidOperationException("unable to compute LocalModelViewProjection");
					return (_LocalModelViewProjection = new ModelMatrix(_LocalProjection * _LocalModelView));
				} else
					return (_LocalModelViewProjection);
			}
			set
			{
				if (value != null) {
					ModelMatrix modelviewprojMatrix = value.Clone() as ModelMatrix;
					if (modelviewprojMatrix == null)
						throw new InvalidOperationException("value is not ModelMatrix");
					_LocalModelViewProjection = modelviewprojMatrix;
				} else
					_LocalModelViewProjection = null;
			}
		}

		/// <summary>
		///  The local projection matrix of this state.
		/// </summary>
		private ModelMatrix _LocalModelViewProjection;

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Push()
		{
			TransformState copiedState = (TransformState)base.Push();

			if (_LocalProjection != null)
				copiedState._LocalProjection = (ProjectionMatrix)_LocalProjection.Clone();
			if (_LocalModel != null)
				copiedState._LocalModel = new ModelMatrix(_LocalModel);
			if (_LocalModelView != null)
				copiedState._LocalModelView = new ModelMatrix(_LocalModelView);
			if (_LocalModelViewProjection != null)
				copiedState._LocalModelViewProjection = new ModelMatrix(_LocalModelViewProjection);

			return (copiedState);
		}

		#endregion
	}
}
