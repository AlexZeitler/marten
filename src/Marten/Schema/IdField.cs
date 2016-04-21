using System;
using System.Reflection;

namespace Marten.Schema
{
    public class IdField : IField
    {
        private readonly MemberInfo _idMember;

        public IdField(MemberInfo idMember)
        {
            _idMember = idMember;
        }

        public MemberInfo[] Members => new[] {_idMember};
        public string MemberName => _idMember.Name;
        public string SqlLocator { get; } = "d.id";
        public string ColumnName { get; } = "id";
        public void WritePatch(DocumentMapping mapping, Action<string> writer)
        {
            // Nothing
        }
    }
}