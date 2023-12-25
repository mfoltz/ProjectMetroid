// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterCraftingSubMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterCraftingSubMenuMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedRecipes;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecipesDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedRecipeRequirements;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__HighlightHelper;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230277, XrefRangeEnd = 1230315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230315, XrefRangeEnd = 1230318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230318, XrefRangeEnd = 1230353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230353, XrefRangeEnd = 1230368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterCraftingSubMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCraftingSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterCraftingSubMenuMapper()
    {
      Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterCraftingSubMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr);
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_UnlockedRecipes));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__RecipesDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_RecipesDatas));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_CachedRecipeRequirements));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_Query));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__HighlightHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, nameof (_HighlightHelper));
      CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, 100665276);
      CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, 100665277);
      CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, 100665278);
      CharacterCraftingSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, 100665279);
      CharacterCraftingSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, 100665280);
    }

    public CharacterCraftingSubMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashSet<PrefabGUID> _UnlockedRecipes
    {
      get
      {
        return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<WorkstationRecipeGridSelectionEntry.Data> _RecipesDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__RecipesDatas));
        return pointer == System.IntPtr.Zero ? (List<WorkstationRecipeGridSelectionEntry.Data>) null : new List<WorkstationRecipeGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__RecipesDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, List<CostData>> _CachedRecipeRequirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, List<CostData>>) null : new Dictionary<int, List<CostData>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIHighlightHelper _HighlightHelper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__HighlightHelper));
        return pointer == System.IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.NativeFieldInfoPtr__HighlightHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.CharacterCraftingSubMenuMapper/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_progressionEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_getOutputItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_localControlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_CharacterCraftingSubMenu_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230085, XrefRangeEnd = 1230277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity menuEntity, CharacterCraftingSubMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &menuEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_CharacterCraftingSubMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr);
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_progressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (progressionEntity));
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (localUserEntity));
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (gameDataSystem));
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getOutputItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (getOutputItems));
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_localControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (localControlledEntity));
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (prefabLookupMap));
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, 100665281);
        CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_CharacterCraftingSubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCraftingSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, 100665282);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CharacterCraftingSubMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CharacterCraftingSubMenuMapper) null : new CharacterCraftingSubMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity progressionEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_progressionEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_progressionEntity)) = value;
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BufferFromEntity<RecipeOutputBuffer> getOutputItems
      {
        get
        {
          return *(BufferFromEntity<RecipeOutputBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getOutputItems));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getOutputItems), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<RecipeOutputBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity localControlledEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_localControlledEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_localControlledEntity)) = value;
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCraftingSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }
    }
  }
}
