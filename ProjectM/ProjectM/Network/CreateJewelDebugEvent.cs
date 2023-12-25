// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CreateJewelDebugEvent
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
  public struct CreateJewelDebugEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Power;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equip;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public PrefabGUID AbilityPrefabGuid;
    [FieldOffset(4)]
    public PrefabGUID SpellModGuid;
    [FieldOffset(8)]
    public int Tier;
    [FieldOffset(12)]
    public float Power;
    [FieldOffset(16)]
    public bool Equip;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145305, XrefRangeEnd = 1145310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateJewelDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145315, RefRangeEnd = 1145316, XrefRangeStart = 1145310, XrefRangeEnd = 1145315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateJewelDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateJewelDebugEvent()
    {
      Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CreateJewelDebugEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr);
      CreateJewelDebugEvent.NativeFieldInfoPtr_AbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, nameof (AbilityPrefabGuid));
      CreateJewelDebugEvent.NativeFieldInfoPtr_SpellModGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, nameof (SpellModGuid));
      CreateJewelDebugEvent.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, nameof (Tier));
      CreateJewelDebugEvent.NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, nameof (Power));
      CreateJewelDebugEvent.NativeFieldInfoPtr_Equip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, nameof (Equip));
      CreateJewelDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, 100690693);
      CreateJewelDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, 100690694);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateJewelDebugEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
