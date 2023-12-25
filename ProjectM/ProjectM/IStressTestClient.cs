// Decompiled with JetBrains decompiler
// Type: ProjectM.IStressTestClient
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
  public class IStressTestClient : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_ConnectionStatusChangeReason_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendTeleportDebugEvent_Public_Abstract_Virtual_New_Void_byref_NativeArray_1_TerrainChunk_byref_Random_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendAdminAuth_Public_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SendChatEvent_Public_Abstract_Virtual_New_Void_String_ChatMessageType_0;
    private static readonly IntPtr NativeMethodInfoPtr_ConfigSettings_Public_Abstract_Virtual_New_Void_StressTestClientMoveStyle_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_TestIncorrectReconnect_Public_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ShutdownRequested_Public_Abstract_Virtual_New_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_ShutdownRequested_Public_Abstract_Virtual_New_set_Void_Boolean_0;

    [CallerCount(0)]
    public virtual unsafe void Shutdown(ConnectionStatusChangeReason leftGame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &leftGame;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_ConnectionStatusChangeReason_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Update(float delta, float timeScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &delta;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &timeScale;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void SendTeleportDebugEvent(
      ref NativeArray<TerrainChunk> terrainChunks,
      ref Unity.Mathematics.Random random)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref terrainChunks;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref random;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_SendTeleportDebugEvent_Public_Abstract_Virtual_New_Void_byref_NativeArray_1_TerrainChunk_byref_Random_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void SendAdminAuth()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_SendAdminAuth_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void SendChatEvent(string msg, ChatMessageType msgType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(msg);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &msgType;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_SendChatEvent_Public_Abstract_Virtual_New_Void_String_ChatMessageType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_ConfigSettings_Public_Abstract_Virtual_New_Void_StressTestClientMoveStyle_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void TestIncorrectReconnect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_TestIncorrectReconnect_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe bool ShutdownRequested
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_get_ShutdownRequested_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IStressTestClient.NativeMethodInfoPtr_set_ShutdownRequested_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static IStressTestClient()
    {
      Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (IStressTestClient));
      IStressTestClient.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_ConnectionStatusChangeReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682661);
      IStressTestClient.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682662);
      IStressTestClient.NativeMethodInfoPtr_SendTeleportDebugEvent_Public_Abstract_Virtual_New_Void_byref_NativeArray_1_TerrainChunk_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682663);
      IStressTestClient.NativeMethodInfoPtr_SendAdminAuth_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682664);
      IStressTestClient.NativeMethodInfoPtr_SendChatEvent_Public_Abstract_Virtual_New_Void_String_ChatMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682665);
      IStressTestClient.NativeMethodInfoPtr_ConfigSettings_Public_Abstract_Virtual_New_Void_StressTestClientMoveStyle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682666);
      IStressTestClient.NativeMethodInfoPtr_TestIncorrectReconnect_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682667);
      IStressTestClient.NativeMethodInfoPtr_get_ShutdownRequested_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682668);
      IStressTestClient.NativeMethodInfoPtr_set_ShutdownRequested_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStressTestClient>.NativeClassPtr, 100682669);
    }

    public IStressTestClient(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
