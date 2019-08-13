﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_Core_ViewWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.Core.View), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("OnMessage", OnMessage);
		L.RegFunction("SendNotification", SendNotification);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.Core.View obj = (Framework.Core.View)ToLua.CheckObject<Framework.Core.View>(L, 1);
			Framework.Interfaces.INotification arg0 = (Framework.Interfaces.INotification)ToLua.CheckObject<Framework.Interfaces.INotification>(L, 2);
			obj.OnMessage(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendNotification(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Framework.Core.View obj = (Framework.Core.View)ToLua.CheckObject<Framework.Core.View>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.SendNotification(arg0);
				return 0;
			}
			else if (count == 3)
			{
				Framework.Core.View obj = (Framework.Core.View)ToLua.CheckObject<Framework.Core.View>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendNotification(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Framework.Core.View.SendNotification");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
