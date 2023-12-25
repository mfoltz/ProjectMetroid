// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DestroyDebugEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyDebugEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_What;
    private static readonly System.IntPtr NativeFieldInfoPtr_Where;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public FixedString128 What;
    [FieldOffset(128)]
    public DestroyDebugEvent.DestroyWhere Where;
    [FieldOffset(132)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(136)]
    public float3 Position;
    [FieldOffset(148)]
    public int Amount;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145290, XrefRangeEnd = 1145297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145304, RefRangeEnd = 1145305, XrefRangeStart = 1145297, XrefRangeEnd = 1145304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyDebugEvent()
    {
      Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (DestroyDebugEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr);
      DestroyDebugEvent.NativeFieldInfoPtr_What = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, nameof (What));
      DestroyDebugEvent.NativeFieldInfoPtr_Where = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, nameof (Where));
      DestroyDebugEvent.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, nameof (PrefabGuid));
      DestroyDebugEvent.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, nameof (Position));
      DestroyDebugEvent.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, nameof (Amount));
      DestroyDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, 100690689);
      DestroyDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, 100690690);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyDebugEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum DestroyWhat
    {
      AnythingExceptSelf,
      Anything,
    }

    public enum DestroyWhere
    {
      ClosestToMouse,
      Anywhere,
    }
  }
}
