using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using Microsoft.Xna.Framework;

namespace BattleChess.Infrastructure
{
    public class DrawableField : DrawableGameObject
    {
        private readonly IField field;

        public DrawableField(IField field)
            : base(field)
        {
            this.field = field;
        }

        public override bool Equals(IGameObject other)
        {
            return TypeIsSame(other) && FieldIsSame((IField) other);
        }

        public override void UpdateGameObject(IGameObject gameObject)
        {
            throw new NotImplementedException();
        }

        private bool TypeIsSame(IGameObject other)
        {
            return other is IField;
        }

        private bool FieldIsSame(IField other)
        {
            return this.field.Equals(other);
        }
    }
}
