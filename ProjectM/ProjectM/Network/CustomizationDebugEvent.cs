﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CustomizationDebugEvent
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
  public struct CustomizationDebugEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public CustomizationCategoryEnum Category;
    [FieldOffset(4)]
    public int Index;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145330, XrefRangeEnd = 1145332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145334, RefRangeEnd = 1145335, XrefRangeStart = 1145332, XrefRangeEnd = 1145334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizationDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomizationDebugEvent()
    {
      Il2CppClassPointerStore<CustomizationDebugEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CustomizationDebugEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationDebugEvent>.NativeClassPtr);
      CustomizationDebugEvent.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationDebugEvent>.NativeClassPtr, nameof (Category));
      CustomizationDebugEvent.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationDebugEvent>.NativeClassPtr, nameof (Index));
      CustomizationDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationDebugEvent>.NativeClassPtr, 100690701);
      CustomizationDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationDebugEvent>.NativeClassPtr, 100690702);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomizationDebugEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
