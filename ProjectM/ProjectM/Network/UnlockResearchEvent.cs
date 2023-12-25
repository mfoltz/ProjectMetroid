﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.UnlockResearchEvent
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
  public struct UnlockResearchEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Researchstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchGUID;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public NetworkId Researchstation;
    [FieldOffset(8)]
    public PrefabGUID ResearchGUID;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145739, XrefRangeEnd = 1145744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockResearchEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145749, RefRangeEnd = 1145750, XrefRangeStart = 1145744, XrefRangeEnd = 1145749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockResearchEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnlockResearchEvent()
    {
      Il2CppClassPointerStore<UnlockResearchEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (UnlockResearchEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockResearchEvent>.NativeClassPtr);
      UnlockResearchEvent.NativeFieldInfoPtr_Researchstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockResearchEvent>.NativeClassPtr, nameof (Researchstation));
      UnlockResearchEvent.NativeFieldInfoPtr_ResearchGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockResearchEvent>.NativeClassPtr, nameof (ResearchGUID));
      UnlockResearchEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockResearchEvent>.NativeClassPtr, 100690842);
      UnlockResearchEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockResearchEvent>.NativeClassPtr, 100690843);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockResearchEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}