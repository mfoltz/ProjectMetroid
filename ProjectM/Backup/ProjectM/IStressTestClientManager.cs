// Decompiled with JetBrains decompiler
// Type: ProjectM.IStressTestClientManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Terrain;
using Stunlock.Network;
using System;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  public class IStressTestClientManager : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeScale_Public_Abstract_Virtual_New_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_IStressTestClient_UInt32_ClientConnectData_String_StressTestClientMoveStyle_Boolean_Boolean_Boolean_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ClientCount_Public_Abstract_Virtual_New_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SpreadInWorld_Public_Abstract_Virtual_New_Void_NativeArray_1_TerrainChunk_0;
    private static readonly IntPtr NativeMethodInfoPtr_TestIncorrectReconnect_Public_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AdminAuth_Public_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendChatEvent_Public_Abstract_Virtual_New_Void_String_ChatMessageType_0;
    private static readonly IntPtr NativeMethodInfoPtr_ConfigSettings_Public_Abstract_Virtual_New_Void_StressTestClientMoveStyle_Boolean_Boolean_0;

    [CallerCount(0)]
    public virtual unsafe void UpdateTimeScale(float timeScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &timeScale;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_UpdateTimeScale_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Shutdown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IStressTestClient Create(
      uint index,
      ClientConnectData clientConnectData,
      string characterName,
      StressTestClientMoveStyle moveStyle,
      bool attack,
      bool respawn,
      bool createThreaded,
      float disconnectAfter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[8];
      numPtr[0] = (IntPtr) &index;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) clientConnectData));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(characterName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &moveStyle;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &attack;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &respawn;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &createThreaded;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &disconnectAfter;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_IStressTestClient_UInt32_ClientConnectData_String_StressTestClientMoveStyle_Boolean_Boolean_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (IStressTestClient) null : new IStressTestClient(pointer);
    }

    public virtual unsafe int ClientCount
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_get_ClientCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Destroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void SpreadInWorld(NativeArray<TerrainChunk> terrainChunks)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &terrainChunks;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_SpreadInWorld_Public_Abstract_Virtual_New_Void_NativeArray_1_TerrainChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void TestIncorrectReconnect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_TestIncorrectReconnect_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void AdminAuth()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_AdminAuth_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void SendChatEvent(string msg, ChatMessageType local)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(msg);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &local;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_SendChatEvent_Public_Abstract_Virtual_New_Void_String_ChatMessageType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void ConfigSettings(
      StressTestClientMoveStyle moveStyle,
      bool attack,
      bool respawn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &moveStyle;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &attack;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &respawn;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClientManager.NativeMethodInfoPtr_ConfigSettings_Public_Abstract_Virtual_New_Void_StressTestClientMoveStyle_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IStressTestClientManager()
    {
      Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (IStressTestClientManager));
      IStressTestClientManager.NativeMethodInfoPtr_UpdateTimeScale_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682651);
      IStressTestClientManager.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682652);
      IStressTestClientManager.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_IStressTestClient_UInt32_ClientConnectData_String_StressTestClientMoveStyle_Boolean_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682653);
      IStressTestClientManager.NativeMethodInfoPtr_get_ClientCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682654);
      IStressTestClientManager.NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682655);
      IStressTestClientManager.NativeMethodInfoPtr_SpreadInWorld_Public_Abstract_Virtual_New_Void_NativeArray_1_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682656);
      IStressTestClientManager.NativeMethodInfoPtr_TestIncorrectReconnect_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682657);
      IStressTestClientManager.NativeMethodInfoPtr_AdminAuth_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682658);
      IStressTestClientManager.NativeMethodInfoPtr_SendChatEvent_Public_Abstract_Virtual_New_Void_String_ChatMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682659);
      IStressTestClientManager.NativeMethodInfoPtr_ConfigSettings_Public_Abstract_Virtual_New_Void_StressTestClientMoveStyle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClientManager>.NativeClassPtr, 100682660);
    }

    public IStressTestClientManager(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
