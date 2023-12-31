// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayConditionComponentData_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class GameplayConditionComponentData_Editor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloatValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoolValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_IntValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabReferenceValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayTimeSpan;
    private static readonly System.IntPtr NativeFieldInfoPtr_TechReferenceValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCategoryValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponTypeValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiPointOfInterestTypeValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitHealthType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffModificationType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayConditionComponentData_Editor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayConditionComponentData_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayConditionComponentData_Editor()
    {
      Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameplayConditionComponentData_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr);
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (ConditionSource));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (ConditionType));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (ConditionTarget));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (FloatValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BoolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (BoolValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_IntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (IntValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_PrefabReferenceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (PrefabReferenceValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_DayTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (DayTimeSpan));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_TechReferenceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (TechReferenceValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (SpellMod));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_EntityCategoryValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (EntityCategoryValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_WeaponTypeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (WeaponTypeValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_AiPointOfInterestTypeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (AiPointOfInterestTypeValue));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ItemCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (ItemCategory));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_UnitHealthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (UnitHealthType));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BuffCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (BuffCategory));
      GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BuffModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, nameof (BuffModificationType));
      GameplayConditionComponentData_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayConditionComponentData_Editor>.NativeClassPtr, 100665947);
    }

    public GameplayConditionComponentData_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ConditionSource ConditionSource
    {
      get
      {
        return *(ConditionSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionSource));
      }
      [param: In] set
      {
        *(ConditionSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionSource)) = value;
      }
    }

    public unsafe ConditionTypes ConditionType
    {
      get
      {
        return *(ConditionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionType));
      }
      [param: In] set
      {
        *(ConditionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionType)) = value;
      }
    }

    public unsafe ConditionTarget ConditionTarget
    {
      get
      {
        return *(ConditionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionTarget));
      }
      [param: In] set
      {
        *(ConditionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ConditionTarget)) = value;
      }
    }

    public unsafe float FloatValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_FloatValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_FloatValue)) = value;
      }
    }

    public unsafe bool BoolValue
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BoolValue));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BoolValue)) = value;
      }
    }

    public unsafe int IntValue
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_IntValue));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_IntValue)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> PrefabReferenceValue
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_PrefabReferenceValue));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_PrefabReferenceValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<DayTimeSpanSettings> DayTimeSpan
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_DayTimeSpan));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<DayTimeSpanSettings>) null : new WeakAssetReference<DayTimeSpanSettings>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_DayTimeSpan), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<UnityEngine.Object> TechReferenceValue
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_TechReferenceValue));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<UnityEngine.Object>) null : new WeakAssetReference<UnityEngine.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_TechReferenceValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<SpellModAsset> SpellMod
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_SpellMod));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<SpellModAsset>) null : new WeakAssetReference<SpellModAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_SpellMod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityCategory EntityCategoryValue
    {
      get
      {
        return *(EntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_EntityCategoryValue));
      }
      [param: In] set
      {
        *(EntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_EntityCategoryValue)) = value;
      }
    }

    public unsafe WeaponType WeaponTypeValue
    {
      get
      {
        return *(WeaponType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_WeaponTypeValue));
      }
      [param: In] set
      {
        *(WeaponType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_WeaponTypeValue)) = value;
      }
    }

    public unsafe AiPointOfInterestType AiPointOfInterestTypeValue
    {
      get
      {
        return *(AiPointOfInterestType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_AiPointOfInterestTypeValue));
      }
      [param: In] set
      {
        *(AiPointOfInterestType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_AiPointOfInterestTypeValue)) = value;
      }
    }

    public unsafe long ItemCategory
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ItemCategory));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_ItemCategory)) = value;
      }
    }

    public unsafe UnitBaseStatsType UnitHealthType
    {
      get
      {
        return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_UnitHealthType));
      }
      [param: In] set
      {
        *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_UnitHealthType)) = value;
      }
    }

    public unsafe long BuffCategory
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BuffCategory));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BuffCategory)) = value;
      }
    }

    public unsafe long BuffModificationType
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BuffModificationType));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayConditionComponentData_Editor.NativeFieldInfoPtr_BuffModificationType)) = value;
      }
    }
  }
}
