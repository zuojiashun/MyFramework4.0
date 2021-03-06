﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MyFramework_ManagerBase_MyFramework_Manager_ManagerModel_MyFramework_ManagerContorBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>), typeof(MyFramework.ManagerBase), "ManagerBase_MyFramework_Manager_ManagerModel_MyFramework_ManagerContorBase");
		L.RegFunction("StartModelForName", StartModelForName);
		L.RegFunction("StartLuaModel", StartLuaModel);
		L.RegFunction("CloseModelForName", CloseModelForName);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartModelForName(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase> obj = (MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>)ToLua.CheckObject<MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase> arg2 = (MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>)ToLua.CheckDelegate<MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>>(L, 4);
			object[] arg3 = ToLua.ToParamsObject(L, 5, count - 4);
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
			int count = LuaDLL.lua_gettop(L);
			MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase> obj = (MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>)ToLua.CheckObject<MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase> arg1 = (MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>)ToLua.CheckDelegate<MyFramework.ModelLoadBackCall<MyFramework.ManagerContorBase>>(L, 3);
			object[] arg2 = ToLua.ToParamsObject(L, 4, count - 3);
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
			MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase> obj = (MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>)ToLua.CheckObject<MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>>(L, 1);
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

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, MyFramework.ManagerBase<MyFramework.Manager_ManagerModel,MyFramework.ManagerContorBase>.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

