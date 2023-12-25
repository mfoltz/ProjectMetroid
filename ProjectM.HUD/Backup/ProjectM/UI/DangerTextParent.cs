// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DangerTextParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class DangerTextParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Motion2DInOut;
    private static readonly IntPtr NativeFieldInfoPtr_Prefab_NoBlood;
    private static readonly IntPtr NativeFieldInfoPtr_Prefab_HolyArea;
    private static readonly IntPtr NativeFieldInfoPtr_Prefab_HeavyHolyArea;
    private static readonly IntPtr NativeFieldInfoPtr_Prefab_Silver;
    private static readonly IntPtr NativeFieldInfoPtr_Prefab_GarlicArea;
    private static readonly IntPtr NativeFieldInfoPtr_DangerText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_SunDamage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_NoBlood;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_HolyDamage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_HeavyHolyDamage;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_GarlicExposure;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Silver;
    private static readonly IntPtr NativeFieldInfoPtr_CurrentDangerTextType;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_EntityManager_PrefabCollectionSystem_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowDangerText_Internal_Void_DangerTextType_0;
    private static readonly IntPtr NativeMethodInfoPtr_Hide_Internal_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256326, XrefRangeEnd = 1256327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hybridEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DangerTextParent.NativeMethodInfoPtr_Initialize_Internal_Void_EntityManager_PrefabCollectionSystem_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256327, XrefRangeEnd = 1256330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DangerTextParent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256330, XrefRangeEnd = 1256335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowDangerText(DangerTextType dangerTextType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &dangerTextType;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DangerTextParent.NativeMethodInfoPtr_ShowDangerText_Internal_Void_DangerTextType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Hide()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DangerTextParent.NativeMethodInfoPtr_Hide_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DangerTextParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DangerTextParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DangerTextParent()
    {
      Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DangerTextParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr);
      DangerTextParent.NativeFieldInfoPtr_Motion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (Motion2DInOut));
      DangerTextParent.NativeFieldInfoPtr_Prefab_NoBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (Prefab_NoBlood));
      DangerTextParent.NativeFieldInfoPtr_Prefab_HolyArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (Prefab_HolyArea));
      DangerTextParent.NativeFieldInfoPtr_Prefab_HeavyHolyArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (Prefab_HeavyHolyArea));
      DangerTextParent.NativeFieldInfoPtr_Prefab_Silver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (Prefab_Silver));
      DangerTextParent.NativeFieldInfoPtr_Prefab_GarlicArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (Prefab_GarlicArea));
      DangerTextParent.NativeFieldInfoPtr_DangerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (DangerText));
      DangerTextParent.NativeFieldInfoPtr_LKey_SunDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (LKey_SunDamage));
      DangerTextParent.NativeFieldInfoPtr_LKey_NoBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (LKey_NoBlood));
      DangerTextParent.NativeFieldInfoPtr_LKey_HolyDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (LKey_HolyDamage));
      DangerTextParent.NativeFieldInfoPtr_LKey_HeavyHolyDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (LKey_HeavyHolyDamage));
      DangerTextParent.NativeFieldInfoPtr_LKey_GarlicExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (LKey_GarlicExposure));
      DangerTextParent.NativeFieldInfoPtr_LKey_Silver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (LKey_Silver));
      DangerTextParent.NativeFieldInfoPtr_CurrentDangerTextType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, nameof (CurrentDangerTextType));
      DangerTextParent.NativeMethodInfoPtr_Initialize_Internal_Void_EntityManager_PrefabCollectionSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, 100666903);
      DangerTextParent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, 100666904);
      DangerTextParent.NativeMethodInfoPtr_ShowDangerText_Internal_Void_DangerTextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, 100666905);
      DangerTextParent.NativeMethodInfoPtr_Hide_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, 100666906);
      DangerTextParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DangerTextParent>.NativeClassPtr, 100666907);
    }

    public DangerTextParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Motion2DInOut Motion2DInOut
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Motion2DInOut));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Motion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Prefab_NoBlood
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_NoBlood));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_NoBlood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Prefab_HolyArea
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_HolyArea));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_HolyArea), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Prefab_HeavyHolyArea
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_HeavyHolyArea));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_HeavyHolyArea), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Prefab_Silver
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_Silver));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_Silver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Prefab_GarlicArea
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_GarlicArea));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_Prefab_GarlicArea), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText DangerText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_DangerText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_DangerText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_SunDamage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_SunDamage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_SunDamage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_NoBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_NoBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_NoBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HolyDamage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_HolyDamage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_HolyDamage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HeavyHolyDamage
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_HeavyHolyDamage));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_HeavyHolyDamage)) = value;
      }
    }

    public unsafe LocalizationKey LKey_GarlicExposure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_GarlicExposure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_GarlicExposure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Silver
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_Silver));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_LKey_Silver)) = value;
      }
    }

    public unsafe DangerTextType CurrentDangerTextType
    {
      get
      {
        return *(DangerTextType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_CurrentDangerTextType));
      }
      [param: In] set
      {
        *(DangerTextType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DangerTextParent.NativeFieldInfoPtr_CurrentDangerTextType)) = value;
      }
    }
  }
}
