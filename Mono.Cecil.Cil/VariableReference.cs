//
// Author:
//   Jb Evain (jbevain@gmail.com)
//
// Copyright (c) 2008 - 2015 Jb Evain
// Copyright (c) 2008 - 2011 Novell, Inc.
//
// Licensed under the MIT/X11 license.
//

namespace Mono.Cecil.Cil {

	public abstract class VariableReference {

		private readonly string name;
		internal int index = -1;
		protected TypeReference variable_type;

		public TypeReference VariableType {
			get { return variable_type; }
			set { variable_type = value; }
		}

		public int Index {
			get { return index; }
		}

		public string Name { get { return this.name; } }

		internal VariableReference (TypeReference variable_type)
		{
			this.variable_type = variable_type;
		}

		internal VariableReference (
			TypeReference variable_type,
			string name)
		{
			this.variable_type = variable_type;
			this.name = name;
		}

		public abstract VariableDefinition Resolve ();

		public override string ToString ()
		{
			if (!string.IsNullOrEmpty(name)) { return this.name; }

			if (index >= 0)
				return "V_" + index;

			return string.Empty;
		}
	}
}
