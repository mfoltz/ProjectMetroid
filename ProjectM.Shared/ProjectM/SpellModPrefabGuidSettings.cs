// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellModPrefabGuidSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class SpellModPrefabGuidSettings : SpellModSettings
  {
    private static readonly IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly IntPtr NativeFieldInfoPtr_UseSpellModValue;
    private static readonly IntPtr NativeFieldInfoPtr_ValueIndex;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModPrefabGuidTarget_Int32_MonoBehaviour_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 728685, RefRangeEnd = 728688, XrefRangeStart = 728666, XrefRangeEnd = 728685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
      Entity entity,
      EntityManager entityManager,
      SpellModPrefabGuidTarget target,
      int targetIndex,
      MonoBehaviour builderComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &target;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &targetIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builderComponent);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModPrefabGuidSettings.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModPrefabGuidTarget_Int32_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModPrefabGuidSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModPrefabGuidSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModPrefabGuidSettings()
    {
      Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellModPrefabGuidSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr);
      SpellModPrefabGuidSettings.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr, nameof (Prefab));
      SpellModPrefabGuidSettings.NativeFieldInfoPtr_UseSpellModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr, nameof (UseSpellModValue));
      SpellModPrefabGuidSettings.NativeFieldInfoPtr_ValueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr, nameof (ValueIndex));
      SpellModPrefabGuidSettings.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_SpellModPrefabGuidTarget_Int32_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr, 100664523);
      SpellModPrefabGuidSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModPrefabGuidSettings>.NativeClassPtr, 100664524);
    }

    public SpellModPrefabGuidSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Prefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModPrefabGuidSettings.NativeFieldInfoPtr_Prefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModPrefabGuidSettings.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseSpellModValue
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModPrefabGuidSettings.NativeFieldInfoPtr_UseSpellModValue));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModPrefabGuidSettings.NativeFieldInfoPtr_UseSpellModValue)) = value;
      }
    }

    public unsafe byte ValueIndex
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModPrefabGuidSettings.NativeFieldInfoPtr_ValueIndex));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModPrefabGuidSettings.NativeFieldInfoPtr_ValueIndex)) = value;
      }
    }
  }
}
