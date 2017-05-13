
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_FRAGMENT_SHADER_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int FRAGMENT_SHADER_ATI = 0x8920;

		/// <summary>
		/// [GL] Value of GL_REG_0_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_0_ATI = 0x8921;

		/// <summary>
		/// [GL] Value of GL_REG_1_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_1_ATI = 0x8922;

		/// <summary>
		/// [GL] Value of GL_REG_2_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_2_ATI = 0x8923;

		/// <summary>
		/// [GL] Value of GL_REG_3_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_3_ATI = 0x8924;

		/// <summary>
		/// [GL] Value of GL_REG_4_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_4_ATI = 0x8925;

		/// <summary>
		/// [GL] Value of GL_REG_5_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_5_ATI = 0x8926;

		/// <summary>
		/// [GL] Value of GL_REG_6_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_6_ATI = 0x8927;

		/// <summary>
		/// [GL] Value of GL_REG_7_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_7_ATI = 0x8928;

		/// <summary>
		/// [GL] Value of GL_REG_8_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_8_ATI = 0x8929;

		/// <summary>
		/// [GL] Value of GL_REG_9_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_9_ATI = 0x892A;

		/// <summary>
		/// [GL] Value of GL_REG_10_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_10_ATI = 0x892B;

		/// <summary>
		/// [GL] Value of GL_REG_11_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_11_ATI = 0x892C;

		/// <summary>
		/// [GL] Value of GL_REG_12_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_12_ATI = 0x892D;

		/// <summary>
		/// [GL] Value of GL_REG_13_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_13_ATI = 0x892E;

		/// <summary>
		/// [GL] Value of GL_REG_14_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_14_ATI = 0x892F;

		/// <summary>
		/// [GL] Value of GL_REG_15_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_15_ATI = 0x8930;

		/// <summary>
		/// [GL] Value of GL_REG_16_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_16_ATI = 0x8931;

		/// <summary>
		/// [GL] Value of GL_REG_17_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_17_ATI = 0x8932;

		/// <summary>
		/// [GL] Value of GL_REG_18_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_18_ATI = 0x8933;

		/// <summary>
		/// [GL] Value of GL_REG_19_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_19_ATI = 0x8934;

		/// <summary>
		/// [GL] Value of GL_REG_20_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_20_ATI = 0x8935;

		/// <summary>
		/// [GL] Value of GL_REG_21_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_21_ATI = 0x8936;

		/// <summary>
		/// [GL] Value of GL_REG_22_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_22_ATI = 0x8937;

		/// <summary>
		/// [GL] Value of GL_REG_23_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_23_ATI = 0x8938;

		/// <summary>
		/// [GL] Value of GL_REG_24_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_24_ATI = 0x8939;

		/// <summary>
		/// [GL] Value of GL_REG_25_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_25_ATI = 0x893A;

		/// <summary>
		/// [GL] Value of GL_REG_26_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_26_ATI = 0x893B;

		/// <summary>
		/// [GL] Value of GL_REG_27_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_27_ATI = 0x893C;

		/// <summary>
		/// [GL] Value of GL_REG_28_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_28_ATI = 0x893D;

		/// <summary>
		/// [GL] Value of GL_REG_29_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_29_ATI = 0x893E;

		/// <summary>
		/// [GL] Value of GL_REG_30_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_30_ATI = 0x893F;

		/// <summary>
		/// [GL] Value of GL_REG_31_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int REG_31_ATI = 0x8940;

		/// <summary>
		/// [GL] Value of GL_CON_0_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_0_ATI = 0x8941;

		/// <summary>
		/// [GL] Value of GL_CON_1_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_1_ATI = 0x8942;

		/// <summary>
		/// [GL] Value of GL_CON_2_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_2_ATI = 0x8943;

		/// <summary>
		/// [GL] Value of GL_CON_3_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_3_ATI = 0x8944;

		/// <summary>
		/// [GL] Value of GL_CON_4_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_4_ATI = 0x8945;

		/// <summary>
		/// [GL] Value of GL_CON_5_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_5_ATI = 0x8946;

		/// <summary>
		/// [GL] Value of GL_CON_6_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_6_ATI = 0x8947;

		/// <summary>
		/// [GL] Value of GL_CON_7_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_7_ATI = 0x8948;

		/// <summary>
		/// [GL] Value of GL_CON_8_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_8_ATI = 0x8949;

		/// <summary>
		/// [GL] Value of GL_CON_9_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_9_ATI = 0x894A;

		/// <summary>
		/// [GL] Value of GL_CON_10_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_10_ATI = 0x894B;

		/// <summary>
		/// [GL] Value of GL_CON_11_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_11_ATI = 0x894C;

		/// <summary>
		/// [GL] Value of GL_CON_12_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_12_ATI = 0x894D;

		/// <summary>
		/// [GL] Value of GL_CON_13_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_13_ATI = 0x894E;

		/// <summary>
		/// [GL] Value of GL_CON_14_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_14_ATI = 0x894F;

		/// <summary>
		/// [GL] Value of GL_CON_15_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_15_ATI = 0x8950;

		/// <summary>
		/// [GL] Value of GL_CON_16_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_16_ATI = 0x8951;

		/// <summary>
		/// [GL] Value of GL_CON_17_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_17_ATI = 0x8952;

		/// <summary>
		/// [GL] Value of GL_CON_18_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_18_ATI = 0x8953;

		/// <summary>
		/// [GL] Value of GL_CON_19_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_19_ATI = 0x8954;

		/// <summary>
		/// [GL] Value of GL_CON_20_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_20_ATI = 0x8955;

		/// <summary>
		/// [GL] Value of GL_CON_21_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_21_ATI = 0x8956;

		/// <summary>
		/// [GL] Value of GL_CON_22_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_22_ATI = 0x8957;

		/// <summary>
		/// [GL] Value of GL_CON_23_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_23_ATI = 0x8958;

		/// <summary>
		/// [GL] Value of GL_CON_24_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_24_ATI = 0x8959;

		/// <summary>
		/// [GL] Value of GL_CON_25_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_25_ATI = 0x895A;

		/// <summary>
		/// [GL] Value of GL_CON_26_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_26_ATI = 0x895B;

		/// <summary>
		/// [GL] Value of GL_CON_27_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_27_ATI = 0x895C;

		/// <summary>
		/// [GL] Value of GL_CON_28_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_28_ATI = 0x895D;

		/// <summary>
		/// [GL] Value of GL_CON_29_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_29_ATI = 0x895E;

		/// <summary>
		/// [GL] Value of GL_CON_30_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_30_ATI = 0x895F;

		/// <summary>
		/// [GL] Value of GL_CON_31_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CON_31_ATI = 0x8960;

		/// <summary>
		/// [GL] Value of GL_MOV_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int MOV_ATI = 0x8961;

		/// <summary>
		/// [GL] Value of GL_ADD_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int ADD_ATI = 0x8963;

		/// <summary>
		/// [GL] Value of GL_MUL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int MUL_ATI = 0x8964;

		/// <summary>
		/// [GL] Value of GL_SUB_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SUB_ATI = 0x8965;

		/// <summary>
		/// [GL] Value of GL_DOT3_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int DOT3_ATI = 0x8966;

		/// <summary>
		/// [GL] Value of GL_DOT4_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int DOT4_ATI = 0x8967;

		/// <summary>
		/// [GL] Value of GL_MAD_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int MAD_ATI = 0x8968;

		/// <summary>
		/// [GL] Value of GL_LERP_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int LERP_ATI = 0x8969;

		/// <summary>
		/// [GL] Value of GL_CND_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CND_ATI = 0x896A;

		/// <summary>
		/// [GL] Value of GL_CND0_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int CND0_ATI = 0x896B;

		/// <summary>
		/// [GL] Value of GL_DOT2_ADD_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int DOT2_ADD_ATI = 0x896C;

		/// <summary>
		/// [GL] Value of GL_SECONDARY_INTERPOLATOR_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SECONDARY_INTERPOLATOR_ATI = 0x896D;

		/// <summary>
		/// [GL] Value of GL_NUM_FRAGMENT_REGISTERS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int NUM_FRAGMENT_REGISTERS_ATI = 0x896E;

		/// <summary>
		/// [GL] Value of GL_NUM_FRAGMENT_CONSTANTS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int NUM_FRAGMENT_CONSTANTS_ATI = 0x896F;

		/// <summary>
		/// [GL] Value of GL_NUM_PASSES_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int NUM_PASSES_ATI = 0x8970;

		/// <summary>
		/// [GL] Value of GL_NUM_INSTRUCTIONS_PER_PASS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971;

		/// <summary>
		/// [GL] Value of GL_NUM_INSTRUCTIONS_TOTAL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972;

		/// <summary>
		/// [GL] Value of GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973;

		/// <summary>
		/// [GL] Value of GL_NUM_LOOPBACK_COMPONENTS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int NUM_LOOPBACK_COMPONENTS_ATI = 0x8974;

		/// <summary>
		/// [GL] Value of GL_COLOR_ALPHA_PAIRING_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int COLOR_ALPHA_PAIRING_ATI = 0x8975;

		/// <summary>
		/// [GL] Value of GL_SWIZZLE_STR_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SWIZZLE_STR_ATI = 0x8976;

		/// <summary>
		/// [GL] Value of GL_SWIZZLE_STQ_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SWIZZLE_STQ_ATI = 0x8977;

		/// <summary>
		/// [GL] Value of GL_SWIZZLE_STR_DR_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SWIZZLE_STR_DR_ATI = 0x8978;

		/// <summary>
		/// [GL] Value of GL_SWIZZLE_STQ_DQ_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SWIZZLE_STQ_DQ_ATI = 0x8979;

		/// <summary>
		/// [GL] Value of GL_SWIZZLE_STRQ_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SWIZZLE_STRQ_ATI = 0x897A;

		/// <summary>
		/// [GL] Value of GL_SWIZZLE_STRQ_DQ_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public const int SWIZZLE_STRQ_DQ_ATI = 0x897B;

		/// <summary>
		/// [GL] Value of GL_RED_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint RED_BIT_ATI = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_GREEN_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint GREEN_BIT_ATI = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_BLUE_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint BLUE_BIT_ATI = 0x00000004;

		/// <summary>
		/// [GL] Value of GL_2X_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint _2X_BIT_ATI = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_4X_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint _4X_BIT_ATI = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_8X_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint _8X_BIT_ATI = 0x00000004;

		/// <summary>
		/// [GL] Value of GL_HALF_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint HALF_BIT_ATI = 0x00000008;

		/// <summary>
		/// [GL] Value of GL_QUARTER_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint QUARTER_BIT_ATI = 0x00000010;

		/// <summary>
		/// [GL] Value of GL_EIGHTH_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint EIGHTH_BIT_ATI = 0x00000020;

		/// <summary>
		/// [GL] Value of GL_SATURATE_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint SATURATE_BIT_ATI = 0x00000040;

		/// <summary>
		/// [GL] Value of GL_COMP_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint COMP_BIT_ATI = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_NEGATE_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint NEGATE_BIT_ATI = 0x00000004;

		/// <summary>
		/// [GL] Value of GL_BIAS_BIT_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		[Log(BitmaskName = "GL")]
		public const uint BIAS_BIT_ATI = 0x00000008;

		/// <summary>
		/// Binding for glGenFragmentShadersATI.
		/// </summary>
		/// <param name="range">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static UInt32 GenFragmentShadersATI(UInt32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenFragmentShadersATI != null, "pglGenFragmentShadersATI not implemented");
			retValue = Delegates.pglGenFragmentShadersATI(range);
			LogCommand("glGenFragmentShadersATI", retValue, range			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindFragmentShaderATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void BindFragmentShaderATI(UInt32 id)
		{
			Debug.Assert(Delegates.pglBindFragmentShaderATI != null, "pglBindFragmentShaderATI not implemented");
			Delegates.pglBindFragmentShaderATI(id);
			LogCommand("glBindFragmentShaderATI", null, id			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDeleteFragmentShaderATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void DeleteFragmentShaderATI(UInt32 id)
		{
			Debug.Assert(Delegates.pglDeleteFragmentShaderATI != null, "pglDeleteFragmentShaderATI not implemented");
			Delegates.pglDeleteFragmentShaderATI(id);
			LogCommand("glDeleteFragmentShaderATI", null, id			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBeginFragmentShaderATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void BeginFragmentShaderATI()
		{
			Debug.Assert(Delegates.pglBeginFragmentShaderATI != null, "pglBeginFragmentShaderATI not implemented");
			Delegates.pglBeginFragmentShaderATI();
			LogCommand("glBeginFragmentShaderATI", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndFragmentShaderATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void EndFragmentShaderATI()
		{
			Debug.Assert(Delegates.pglEndFragmentShaderATI != null, "pglEndFragmentShaderATI not implemented");
			Delegates.pglEndFragmentShaderATI();
			LogCommand("glEndFragmentShaderATI", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPassTexCoordATI.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="swizzle">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void PassTexCoordATI(UInt32 dst, UInt32 coord, Int32 swizzle)
		{
			Debug.Assert(Delegates.pglPassTexCoordATI != null, "pglPassTexCoordATI not implemented");
			Delegates.pglPassTexCoordATI(dst, coord, swizzle);
			LogCommand("glPassTexCoordATI", null, dst, coord, swizzle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSampleMapATI.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="interp">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="swizzle">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void SampleMapATI(UInt32 dst, UInt32 interp, Int32 swizzle)
		{
			Debug.Assert(Delegates.pglSampleMapATI != null, "pglSampleMapATI not implemented");
			Delegates.pglSampleMapATI(dst, interp, swizzle);
			LogCommand("glSampleMapATI", null, dst, interp, swizzle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorFragmentOp1ATI.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:FragmentOpATI"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void ColorFragmentOp1ATI(FragmentOpATI op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod)
		{
			Debug.Assert(Delegates.pglColorFragmentOp1ATI != null, "pglColorFragmentOp1ATI not implemented");
			Delegates.pglColorFragmentOp1ATI((Int32)op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
			LogCommand("glColorFragmentOp1ATI", null, op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorFragmentOp2ATI.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:FragmentOpATI"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void ColorFragmentOp2ATI(FragmentOpATI op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod)
		{
			Debug.Assert(Delegates.pglColorFragmentOp2ATI != null, "pglColorFragmentOp2ATI not implemented");
			Delegates.pglColorFragmentOp2ATI((Int32)op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
			LogCommand("glColorFragmentOp2ATI", null, op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorFragmentOp3ATI.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:FragmentOpATI"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg3">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg3Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg3Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void ColorFragmentOp3ATI(FragmentOpATI op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod)
		{
			Debug.Assert(Delegates.pglColorFragmentOp3ATI != null, "pglColorFragmentOp3ATI not implemented");
			Delegates.pglColorFragmentOp3ATI((Int32)op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
			LogCommand("glColorFragmentOp3ATI", null, op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glAlphaFragmentOp1ATI.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:FragmentOpATI"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void AlphaFragmentOp1ATI(FragmentOpATI op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod)
		{
			Debug.Assert(Delegates.pglAlphaFragmentOp1ATI != null, "pglAlphaFragmentOp1ATI not implemented");
			Delegates.pglAlphaFragmentOp1ATI((Int32)op, dst, dstMod, arg1, arg1Rep, arg1Mod);
			LogCommand("glAlphaFragmentOp1ATI", null, op, dst, dstMod, arg1, arg1Rep, arg1Mod			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glAlphaFragmentOp2ATI.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:FragmentOpATI"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void AlphaFragmentOp2ATI(FragmentOpATI op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod)
		{
			Debug.Assert(Delegates.pglAlphaFragmentOp2ATI != null, "pglAlphaFragmentOp2ATI not implemented");
			Delegates.pglAlphaFragmentOp2ATI((Int32)op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
			LogCommand("glAlphaFragmentOp2ATI", null, op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glAlphaFragmentOp3ATI.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:FragmentOpATI"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstMod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg1Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg2Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg3">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg3Rep">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="arg3Mod">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void AlphaFragmentOp3ATI(FragmentOpATI op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod)
		{
			Debug.Assert(Delegates.pglAlphaFragmentOp3ATI != null, "pglAlphaFragmentOp3ATI not implemented");
			Delegates.pglAlphaFragmentOp3ATI((Int32)op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
			LogCommand("glAlphaFragmentOp3ATI", null, op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSetFragmentShaderConstantATI.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		public static void SetFragmentShaderConstantATI(UInt32 dst, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglSetFragmentShaderConstantATI != null, "pglSetFragmentShaderConstantATI not implemented");
					Delegates.pglSetFragmentShaderConstantATI(dst, p_value);
					LogCommand("glSetFragmentShaderConstantATI", null, dst, value					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenFragmentShadersATI", ExactSpelling = true)]
			internal extern static UInt32 glGenFragmentShadersATI(UInt32 range);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glBindFragmentShaderATI(UInt32 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glDeleteFragmentShaderATI(UInt32 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBeginFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glBeginFragmentShaderATI();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEndFragmentShaderATI", ExactSpelling = true)]
			internal extern static void glEndFragmentShaderATI();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPassTexCoordATI", ExactSpelling = true)]
			internal extern static void glPassTexCoordATI(UInt32 dst, UInt32 coord, Int32 swizzle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSampleMapATI", ExactSpelling = true)]
			internal extern static void glSampleMapATI(UInt32 dst, UInt32 interp, Int32 swizzle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorFragmentOp1ATI", ExactSpelling = true)]
			internal extern static void glColorFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorFragmentOp2ATI", ExactSpelling = true)]
			internal extern static void glColorFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorFragmentOp3ATI", ExactSpelling = true)]
			internal extern static void glColorFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFragmentOp1ATI", ExactSpelling = true)]
			internal extern static void glAlphaFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFragmentOp2ATI", ExactSpelling = true)]
			internal extern static void glAlphaFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFragmentOp3ATI", ExactSpelling = true)]
			internal extern static void glAlphaFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSetFragmentShaderConstantATI", ExactSpelling = true)]
			internal extern static unsafe void glSetFragmentShaderConstantATI(UInt32 dst, float* value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenFragmentShadersATI(UInt32 range);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glGenFragmentShadersATI pglGenFragmentShadersATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFragmentShaderATI(UInt32 id);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glBindFragmentShaderATI pglBindFragmentShaderATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteFragmentShaderATI(UInt32 id);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glDeleteFragmentShaderATI pglDeleteFragmentShaderATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginFragmentShaderATI();

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glBeginFragmentShaderATI pglBeginFragmentShaderATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndFragmentShaderATI();

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glEndFragmentShaderATI pglEndFragmentShaderATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPassTexCoordATI(UInt32 dst, UInt32 coord, Int32 swizzle);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glPassTexCoordATI pglPassTexCoordATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMapATI(UInt32 dst, UInt32 interp, Int32 swizzle);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glSampleMapATI pglSampleMapATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glColorFragmentOp1ATI pglColorFragmentOp1ATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glColorFragmentOp2ATI pglColorFragmentOp2ATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glColorFragmentOp3ATI pglColorFragmentOp3ATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFragmentOp1ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glAlphaFragmentOp1ATI pglAlphaFragmentOp1ATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFragmentOp2ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glAlphaFragmentOp2ATI pglAlphaFragmentOp2ATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFragmentOp3ATI(Int32 op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glAlphaFragmentOp3ATI pglAlphaFragmentOp3ATI;

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSetFragmentShaderConstantATI(UInt32 dst, float* value);

			[RequiredByFeature("GL_ATI_fragment_shader")]
			[ThreadStatic]
			internal static glSetFragmentShaderConstantATI pglSetFragmentShaderConstantATI;

		}
	}

}
