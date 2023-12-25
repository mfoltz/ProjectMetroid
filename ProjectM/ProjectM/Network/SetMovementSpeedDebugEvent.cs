﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SetMovementSpeedDebugEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetMovementSpeedDebugEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Force;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public float Value;
    [FieldOffset(4)]
    public bool Force;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145415, XrefRangeEnd = 1145417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetMovementSpeedDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145419, RefRangeEnd = 1145420, XrefRangeStart = 1145417, XrefRangeEnd = 1145419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetMovementSpeedDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetMovementSpeedDebugEvent()
    {
      Il2CppClassPointerStore<SetMovementSpeedDebugEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SetMovementSpeedDebugEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetMovementSpeedDebugEvent>.NativeClassPtr);
      SetMovementSpeedDebugEvent.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMovementSpeedDebugEvent>.NativeClassPtr, nameof (Value));
      SetMovementSpeedDebugEvent.NativeFieldInfoPtr_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMovementSpeedDebugEvent>.NativeClassPtr, nameof (Force));
      SetMovementSpeedDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMovementSpeedDebugEvent>.NativeClassPtr, 100690757);
      SetMovementSpeedDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMovementSpeedDebugEvent>.NativeClassPtr, 100690758);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetMovementSpeedDebugEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
