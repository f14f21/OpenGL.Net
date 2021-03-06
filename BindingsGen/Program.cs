
// Copyright (C) 2015-2017 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL bindings generator.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Application entry point.
		/// </summary>
		/// <param name="args">
		/// The command line invocation arguments.
		/// </param>
		static void Main(string[] args)
		{
			RegistryContext ctx;
			RegistryProcessor glRegistryProcessor;
			int index;

			DummyStream = Array.FindIndex(args, delegate(string item) { return (item == "--dummy"); }) >= 0;
			DocDisabled= Array.FindIndex(args, delegate(string item) { return (item == "--nodoc"); }) >= 0;

			#region Assembly processing

			if ((args.Length > 0) && ((index = Array.FindIndex(args, delegate(string item) { return (item == "--assembly"); })) >= 0)) {
				string assemblyPath = args[index + 1];
				bool overwriteAssembly = Array.Exists(args, delegate(string item) { return (item.StartsWith("--assembly-overwrite")); });
				bool profileOnlyOpts = Array.Exists(args, delegate(string item) { return (item.StartsWith("--profile-")); });

				List<RegistryAssemblyConfiguration> cfgs = new List<RegistryAssemblyConfiguration>();

				if (profileOnlyOpts == false) {
					cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.CoreProfile.xml"));
					cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.ES2Profile.xml"));
					cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.SC2Profile.xml"));
				} else {
					if (Array.Exists(args, delegate(string item) { return (item.StartsWith("--profile-core")); }))
						cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.CoreProfile.xml"));
					if (Array.Exists(args, delegate(string item) { return (item.StartsWith("--profile-es2")); }))
						cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.ES2Profile.xml"));
					if (Array.Exists(args, delegate(string item) { return (item.StartsWith("--profile-sc2")); }))
						cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.SC2Profile.xml"));
				}

				foreach (RegistryAssemblyConfiguration cfg in cfgs) {
					try {
						RegistryAssembly.CleanAssembly(assemblyPath, cfg, overwriteAssembly);
					} catch (Exception exception) {
						Console.WriteLine("Unable to process assembly: {0}.", exception.ToString());
					}
				}

				// Exclusive option
				return;
			}

			#endregion

			#region Log Maps

			if ((args.Length > 0) && (Array.FindIndex(args, delegate(string item) { return (item == "--only-logmaps"); }) >= 0)) {
				if ((args.Length == 1) || (Array.FindIndex(args, delegate(string item) { return (item == "--gl"); }) >= 0)) {
					Console.WriteLine("Generating GL log map...");
					ctx = new RegistryContext("Gl", Path.Combine(BasePath, "GLSpecs/gl.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGl.xml"));
				}

				if ((args.Length == 1) || (Array.FindIndex(args, delegate(string item) { return (item == "--wgl"); }) >= 0)) {
					Console.WriteLine("Generating WGL log map...");
					ctx = new RegistryContext("Wgl", Path.Combine(BasePath, "GLSpecs/wgl.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapWgl.xml"));
				}

				if ((args.Length == 1) || (Array.FindIndex(args, delegate(string item) { return (item == "--glx"); }) >= 0)) {
					Console.WriteLine("Generating GLX log map...");
					ctx = new RegistryContext("Glx", Path.Combine(BasePath, "GLSpecs/glx.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGlx.xml"));
				}

				if ((args.Length == 1) || (Array.FindIndex(args, delegate(string item) { return (item == "--egl"); }) >= 0)) {
					Console.WriteLine("Generating EGL log map...");
					ctx = new RegistryContext("Egl", Path.Combine(BasePath, "GLSpecs/egl.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapEgl.xml"));
				}

				// Exclusive option
				return;
			}

			#endregion

			// (Common) Documentation
			RegistryDocumentation<RegistryDocumentationHandler_GL4> gl4Documentation = new RegistryDocumentation<RegistryDocumentationHandler_GL4>();
			gl4Documentation.Api = "GL4";
			if (DocDisabled == false)
				gl4Documentation.ScanDocumentation(Path.Combine(BasePath, "Refpages/OpenGL/gl4"));

			RegistryDocumentation<RegistryDocumentationHandler_GL2> gl2Documentation = new RegistryDocumentation<RegistryDocumentationHandler_GL2>();
			gl2Documentation.Api = "GL2.1";
			if (DocDisabled == false)
				gl2Documentation.ScanDocumentation(Path.Combine(BasePath, "Refpages/OpenGL/gl2.1"));

			// XML-based specifications

			// OpenGL
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--gl"); }) >= 0)) {
				// Additional ES documentation
				RegistryDocumentation<RegistryDocumentationHandler_GL4> gles3Documentation = new RegistryDocumentation<RegistryDocumentationHandler_GL4>();
				gles3Documentation.Api = "GLES3.2";
				if (DocDisabled == false)
					gles3Documentation.ScanDocumentation(Path.Combine(BasePath, "Refpages/OpenGL/es3"));

				RegistryDocumentation<RegistryDocumentationHandler_GL2> gles1Documentation = new RegistryDocumentation<RegistryDocumentationHandler_GL2>();
				gles1Documentation.Api = "GLES1.1";
				if (DocDisabled == false)
					gles1Documentation.ScanDocumentation(Path.Combine(BasePath, "Refpages/OpenGL/es1.1"));

				Console.WriteLine("Loading GL specification...");
				ctx = new RegistryContext("Gl", Path.Combine(BasePath, "GLSpecs/gl.xml"));
				ctx.RefPages.Add(gl4Documentation);
				ctx.RefPages.Add(gl2Documentation);
				ctx.RefPages.Add(gles3Documentation);
				ctx.RefPages.Add(gles1Documentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("{0}/{1}.Enums.cs", OutputBasePath, ctx.Class)));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateLimitsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGl.xml"));
			}

			// OpenGL for Windows
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--wgl"); }) >= 0)) {
				ctx = new RegistryContext("Wgl", Path.Combine(BasePath, "GLSpecs/wgl.xml"));
				ctx.RefPages.Add(gl4Documentation);
				ctx.RefPages.Add(gl2Documentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("{0}/{1}.Enums.cs", OutputBasePath, ctx.Class)));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapWgl.xml"));
			}

			// OpenGL for Unix
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--glx"); }) >= 0)) {
				ctx = new RegistryContext("Glx", Path.Combine(BasePath, "GLSpecs/glx.xml"));
				ctx.RefPages.Add(gl4Documentation);
				ctx.RefPages.Add(gl2Documentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("{0}/{1}.Enums.cs", OutputBasePath, ctx.Class)));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGlx.xml"));
			}

			// EGL
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--egl"); }) >= 0)) {
				RegistryDocumentation<RegistryDocumentationHandler_EGL> eglDocumentation = new RegistryDocumentation<RegistryDocumentationHandler_EGL>();
				eglDocumentation.Api = "EGL";
				eglDocumentation.ScanDocumentation(Path.Combine(BasePath, "Refpages/EGL-Registry/sdk/docs/man"));

				ctx = new RegistryContext("Egl", Path.Combine(BasePath, "GLSpecs/egl.xml"));
				ctx.RefPages.Add(eglDocumentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("{0}/{1}.Enums.cs", OutputBasePath, ctx.Class)));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapEgl.xml"));
			}

			// OpenWF

			OutputBasePath = "OpenWF.Net";

			// OpenWF(C)
			// Note: you must setup CLI to generate this bindings
			if ((args.Length > 0) && (Array.FindIndex(args, delegate(string item) { return (item == "--wfc"); }) >= 0)) {
				Header headRegistry = new Header("Wfc");
				headRegistry.AppendHeader(Path.Combine(BasePath, "GLSpecs/WF/wfc.h"));

				ctx = new RegistryContext("Wfc", headRegistry);
				glRegistryProcessor = new RegistryProcessor(ctx.Registry, "OpenWF");
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("{0}/{1}.Enums.cs", OutputBasePath, ctx.Class)));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass( ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
			}

			// OpenWF(D)
			if ((args.Length == 0) || (Array.FindIndex(args, delegate(string item) { return (item == "--wfd"); }) >= 0)) {
				Header headRegistry = new Header("Wfd");
				headRegistry.AppendHeader(Path.Combine(BasePath, "GLSpecs/WF/wfd.h"));

				ctx = new RegistryContext("Wfd", headRegistry);
				glRegistryProcessor = new RegistryProcessor(ctx.Registry, "OpenWF");
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("{0}/{1}.Enums.cs", OutputBasePath, ctx.Class)));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
			}
		}

		public static bool DocDisabled;

		public static bool DummyStream;

		/// <summary>
		/// Base path to construct correct file paths.
		/// </summary>
		public static readonly string BasePath = "../../..";

		/// <summary>
		/// The directory where the output files are placed.
		/// </summary>
		public static string OutputBasePath = "OpenGL.Net";
	}
}
