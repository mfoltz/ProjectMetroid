// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.INetworkEventData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public class INetworkEventData : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_byref_NetBufferIn_EntityManager_0;

    [CallerCount(0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref netBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), INetworkEventData.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_byref_NetBufferOut_EntityManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref netBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), INetworkEventData.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_byref_NetBufferIn_EntityManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static INetworkEventData()
    {
      Il2CppClassPointerStore<INetworkEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (INetworkEventData));
      INetworkEventData.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkEventData>.NativeClassPtr, 100690766);
      INetworkEventData.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkEventData>.NativeClassPtr, 100690767);
    }

    public INetworkEventData(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
