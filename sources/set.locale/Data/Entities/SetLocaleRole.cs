﻿using System;
using System.Collections.Generic;

namespace set.locale.Data.Entities
{
    public class SetLocaleRole
    {
        public readonly int Value;

        public static readonly SetLocaleRole Admin = new SetLocaleRole(1);
        public static readonly SetLocaleRole Developer = new SetLocaleRole(2);
        public static readonly SetLocaleRole User = new SetLocaleRole(3);
        public static readonly SetLocaleRole Translator = new SetLocaleRole(4);

        public SetLocaleRole(int v)
        {
            Value = v;
        }

        public override string ToString()
        {
            return GetString(Value);
        }

        public static Dictionary<int, string> GetItemList()
        {
            var list = new Dictionary<int, string> { { 1, "Admin" }, { 2, "Developer" }, { 3, "User" }, { 4, "Translator" } };
            return list;
        }

        public static bool IsValid(int id)
        {
            return id > 0 && id <= GetItemList().Count;
        }

        public static string GetString(int id)
        {
            var list = GetItemList();

            if (!list.ContainsKey(id))
            {
                throw new Exception("Unknown RoleId > " + id);
            }

            return list[id];
        }
    }
}