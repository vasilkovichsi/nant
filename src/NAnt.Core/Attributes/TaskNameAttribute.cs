// NAnt - A .NET build tool
// Copyright (C) 2001 Gerry Shaw
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Gerry Shaw (gerry_shaw@yahoo.com)

namespace SourceForge.NAnt.Attributes {

    using System;

    /// <summary>Indicates that class should be treated as a task.</summary>
    /// <remarks>
    /// Attach this attribute to a subclass of Task to have NAnt be able
    /// to recognize it.  The name should be short but must not confict
    /// with any other task already in use.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class, Inherited=false, AllowMultiple=false)]
    public sealed class TaskNameAttribute : Attribute {
        #region Private Instance Fields

        string _name;

        #endregion Private Instance Fields

        #region Public Instance Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskNameAttribute" /> class
        /// with the specified name.
        /// </summary>
        /// <param name="name">The name of the task.</param>
        public TaskNameAttribute(string name) {            
            _name = name;
        }

        #endregion Public Instance Constructors

        #region Public Instance Properties

        /// <summary>
        /// Gets or sets the name of the task.
        /// </summary>
        /// <value>The name of the task.</value>
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        #endregion Public Instance Properties
    }
}
