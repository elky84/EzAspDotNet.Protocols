﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EzAspDotNet.Protocols.Common
{
    // [열거형 형식 대신 열거형 클래스 사용 | Microsoft Docs] (https://docs.microsoft.com/ko-kr/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types)
    public abstract class Enumeration : IComparable
    {
        protected Enumeration(int id, string name) => (Id, Description) = (id, name);

        public Enumeration()
        {
        }

        public string Description { get; set; }

        public int Id { get; set; }

        public override string ToString() => Description;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                     .Select(f => f.GetValue(null))
                     .Cast<T>();

        public override bool Equals(object obj)
        {
            if (!(obj is Enumeration otherValue))
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);

        public override int GetHashCode()
        {
            return Description.GetHashCode();
        }

        // Other utility methods ...
    }
}
