﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaListItemWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaListItem), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("AddClick", AddClick);
		L.RegFunction("AddSliderChange", AddSliderChange);
		L.RegFunction("AddToggleClick", AddToggleClick);
		L.RegFunction("RemoveClick", RemoveClick);
		L.RegFunction("ClearClick", ClearClick);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes<UnityEngine.GameObject, LuaInterface.LuaFunction, LuaInterface.LuaTable>(L, 2))
			{
				LuaListItem obj = (LuaListItem)ToLua.CheckObject<LuaListItem>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 3);
				LuaTable arg2 = ToLua.ToLuaTable(L, 4);
				obj.AddClick(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<UnityEngine.UI.Button, LuaInterface.LuaFunction, LuaInterface.LuaTable>(L, 2))
			{
				LuaListItem obj = (LuaListItem)ToLua.CheckObject<LuaListItem>(L, 1);
				UnityEngine.UI.Button arg0 = (UnityEngine.UI.Button)ToLua.ToObject(L, 2);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 3);
				LuaTable arg2 = ToLua.ToLuaTable(L, 4);
				obj.AddClick(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaListItem.AddClick");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddSliderChange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			LuaListItem obj = (LuaListItem)ToLua.CheckObject<LuaListItem>(L, 1);
			UnityEngine.UI.Slider arg0 = (UnityEngine.UI.Slider)ToLua.CheckObject<UnityEngine.UI.Slider>(L, 2);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			LuaTable arg2 = ToLua.CheckLuaTable(L, 4);
			obj.AddSliderChange(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddToggleClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			LuaListItem obj = (LuaListItem)ToLua.CheckObject<LuaListItem>(L, 1);
			UnityEngine.UI.Toggle arg0 = (UnityEngine.UI.Toggle)ToLua.CheckObject<UnityEngine.UI.Toggle>(L, 2);
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			LuaTable arg2 = ToLua.CheckLuaTable(L, 4);
			obj.AddToggleClick(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaListItem obj = (LuaListItem)ToLua.CheckObject<LuaListItem>(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveClick(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaListItem obj = (LuaListItem)ToLua.CheckObject<LuaListItem>(L, 1);
			obj.ClearClick();
			return 0;
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
