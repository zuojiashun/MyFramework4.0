﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MyFramework_Manager_ManagerModelWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MyFramework.Manager_ManagerModel), typeof(MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>));
		L.RegFunction("StartModelForName", StartModelForName);
		L.RegFunction("StartLuaModel", StartLuaModel);
		L.RegFunction("CloseModelForName", CloseModelForName);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartModelForName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			MyFramework.Manager_ManagerModel obj = (MyFramework.Manager_ManagerModel)ToLua.CheckObject<MyFramework.Manager_ManagerModel>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase> arg2 = (MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>)ToLua.CheckDelegate<MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>>(L, 4);
			object[] arg3 = ToLua.CheckObjectArray(L, 5);
			obj.StartModelForName(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartLuaModel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			MyFramework.Manager_ManagerModel obj = (MyFramework.Manager_ManagerModel)ToLua.CheckObject<MyFramework.Manager_ManagerModel>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase> arg1 = (MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>)ToLua.CheckDelegate<MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>>(L, 3);
			object[] arg2 = ToLua.CheckObjectArray(L, 4);
			obj.StartLuaModel(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseModelForName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MyFramework.Manager_ManagerModel obj = (MyFramework.Manager_ManagerModel)ToLua.CheckObject<MyFramework.Manager_ManagerModel>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.CloseModelForName(arg0);
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

