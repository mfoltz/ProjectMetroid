// Decompiled with JetBrains decompiler
// Type: ProjectM.Faction
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Faction
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFriendlyTowards_Public_Boolean_byref_Faction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNeutralTowards_Public_Boolean_byref_Faction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHostileTowards_Public_Boolean_byref_Faction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasRelationTowards_Public_Boolean_FactionRelation_byref_Faction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasRelationTowards_Public_Boolean_FactionEnum_byref_Faction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRelation_Public_FactionEnum_FactionRelation_0;
    [FieldOffset(0)]
    public BlobAssetReference<FactionBlobAsset> Data;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723041, XrefRangeEnd = 723047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFriendlyTowards([In] ref Faction faction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref faction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Faction.NativeMethodInfoPtr_IsFriendlyTowards_Public_Boolean_byref_Faction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723047, XrefRangeEnd = 723053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsNeutralTowards([In] ref Faction faction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref faction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Faction.NativeMethodInfoPtr_IsNeutralTowards_Public_Boolean_byref_Faction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723053, XrefRangeEnd = 723059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHostileTowards([In] ref Faction faction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref faction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Faction.NativeMethodInfoPtr_IsHostileTowards_Public_Boolean_byref_Faction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723059, XrefRangeEnd = 723063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasRelationTowards(FactionRelation relation, [In] ref Faction faction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &relation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref faction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Faction.NativeMethodInfoPtr_HasRelationTowards_Public_Boolean_FactionRelation_byref_Faction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723063, XrefRangeEnd = 723066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasRelationTowards(FactionEnum relation, [In] ref Faction faction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &relation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref faction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Faction.NativeMethodInfoPtr_HasRelationTowards_Public_Boolean_FactionEnum_byref_Faction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 723069, RefRangeEnd = 723070, XrefRangeStart = 723066, XrefRangeEnd = 723069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FactionEnum GetRelation(FactionRelation relation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &relation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Faction.NativeMethodInfoPtr_GetRelation_Public_FactionEnum_FactionRelation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FactionEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Faction()
    {
      Il2CppClassPointerStore<Faction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Faction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Faction>.NativeClassPtr);
      Faction.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Faction>.NativeClassPtr, nameof (Data));
      Faction.NativeMethodInfoPtr_IsFriendlyTowards_Public_Boolean_byref_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Faction>.NativeClassPtr, 100663896);
      Faction.NativeMethodInfoPtr_IsNeutralTowards_Public_Boolean_byref_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Faction>.NativeClassPtr, 100663897);
      Faction.NativeMethodInfoPtr_IsHostileTowards_Public_Boolean_byref_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Faction>.NativeClassPtr, 100663898);
      Faction.NativeMethodInfoPtr_HasRelationTowards_Public_Boolean_FactionRelation_byref_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Faction>.NativeClassPtr, 100663899);
      Faction.NativeMethodInfoPtr_HasRelationTowards_Public_Boolean_FactionEnum_byref_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Faction>.NativeClassPtr, 100663900);
      Faction.NativeMethodInfoPtr_GetRelation_Public_FactionEnum_FactionRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Faction>.NativeClassPtr, 100663901);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Faction>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
