// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UnitBloodQualityBuff
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class UnitBloodQualityBuff : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_BloodType;
    private static readonly IntPtr NativeFieldInfoPtr_Buff;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitBloodQualityBuff.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794521, XrefRangeEnd = 794532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitBloodQualityBuff.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitBloodQualityBuff.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitBloodQualityBuff()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitBloodQualityBuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitBloodQualityBuff()
    {
      Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (UnitBloodQualityBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr);
      UnitBloodQualityBuff.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr, nameof (BloodType));
      UnitBloodQualityBuff.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr, nameof (Buff));
      UnitBloodQualityBuff.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr, nameof (_Guid));
      UnitBloodQualityBuff.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr, 100670056);
      UnitBloodQualityBuff.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr, 100670057);
      UnitBloodQualityBuff.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr, 100670058);
      UnitBloodQualityBuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitBloodQualityBuff>.NativeClassPtr, 100670059);
    }

    public UnitBloodQualityBuff(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitBloodType BloodType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodQualityBuff.NativeFieldInfoPtr_BloodType));
        return pointer == IntPtr.Zero ? (UnitBloodType) null : new UnitBloodType(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodQualityBuff.NativeFieldInfoPtr_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent Buff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodQualityBuff.NativeFieldInfoPtr_Buff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodQualityBuff.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodQualityBuff.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitBloodQualityBuff.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
