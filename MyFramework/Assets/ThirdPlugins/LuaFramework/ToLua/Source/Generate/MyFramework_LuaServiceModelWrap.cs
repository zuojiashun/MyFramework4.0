﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MyFramework_LuaServiceModelWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MyFramework.LuaServiceModel), typeof(MyFramework.LuaModelControlBase<MyFramework.LuaServiceModel>));
		L.RegFunction("Load", Load);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("SendMesageUdp", SendMesageUdp);
		L.RegFunction("RecvMessage", RecvMessage);
		L.RegFunction("DealMessage", DealMessage);
		L.RegFunction("New", _CreateMyFramework_LuaServiceModel);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Ip", get_Ip, set_Ip);
		L.RegVar("Port", get_Port, set_Port);
		L.RegVar("UdpPort", get_UdpPort, set_UdpPort);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMyFramework_LuaServiceModel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MyFramework.LuaServiceModel obj = new MyFramework.LuaServiceModel();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MyFramework.LuaServiceModel.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)ToLua.CheckObject<MyFramework.LuaServiceModel>(L, 1);
			object[] arg0 = ToLua.CheckObjectArray(L, 2);
			obj.Load(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)ToLua.CheckObject<MyFramework.LuaServiceModel>(L, 1);
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);
			byte arg1 = (byte)LuaDLL.luaL_checknumber(L, 3);
			LuaByteBuffer arg2 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 4));
			obj.SendMessage(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMesageUdp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)ToLua.CheckObject<MyFramework.LuaServiceModel>(L, 1);
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);
			byte arg1 = (byte)LuaDLL.luaL_checknumber(L, 3);
			LuaByteBuffer arg2 = new LuaByteBuffer(ToLua.CheckByteBuffer(L, 4));
			obj.SendMesageUdp(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RecvMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)ToLua.CheckObject<MyFramework.LuaServiceModel>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			int o = obj.RecvMessage(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DealMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)ToLua.CheckObject<MyFramework.LuaServiceModel>(L, 1);
			MyFramework.CSMessage arg0 = (MyFramework.CSMessage)ToLua.CheckObject<MyFramework.CSMessage>(L, 2);
			obj.DealMessage(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Ip(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)o;
			string ret = obj.Ip;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Ip on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Port(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)o;
			int ret = obj.Port;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Port on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UdpPort(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)o;
			int ret = obj.UdpPort;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index UdpPort on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Ip(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.Ip = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Ip on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Port(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Port = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Port on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UdpPort(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MyFramework.LuaServiceModel obj = (MyFramework.LuaServiceModel)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.UdpPort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index UdpPort on a nil value");
		}
	}
}

