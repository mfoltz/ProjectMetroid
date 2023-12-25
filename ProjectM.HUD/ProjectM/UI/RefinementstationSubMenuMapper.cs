// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.RefinementstationSubMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class RefinementstationSubMenuMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__BonusDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecipesDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutputDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244448, XrefRangeEnd = 1244479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RefinementstationSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244479, XrefRangeEnd = 1244506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RefinementstationSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244506, XrefRangeEnd = 1244533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RefinementstationSubMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RefinementstationSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RefinementstationSubMenuMapper()
    {
      Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (RefinementstationSubMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr);
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__BonusDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_BonusDatas));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__RecipesDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_RecipesDatas));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__InputDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_InputDatas));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__OutputDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_OutputDatas));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_Query));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_ServerTimeAccessor));
      RefinementstationSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      RefinementstationSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, 100666224);
      RefinementstationSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, 100666225);
      RefinementstationSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, 100666226);
      RefinementstationSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, 100666227);
    }

    public RefinementstationSubMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<StationBonusEntry.Data> _BonusDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__BonusDatas));
        return pointer == System.IntPtr.Zero ? (List<StationBonusEntry.Data>) null : new List<StationBonusEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__BonusDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RefinementstationRecipeEntry.Data> _RecipesDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__RecipesDatas));
        return pointer == System.IntPtr.Zero ? (List<RefinementstationRecipeEntry.Data>) null : new List<RefinementstationRecipeEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__RecipesDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _InputDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__InputDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__InputDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _OutputDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__OutputDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__OutputDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RefinementstationTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      [FieldOffset(0)]
      public Entity Target;

      static RefinementstationTarget()
      {
        Il2CppClassPointerStore<RefinementstationSubMenuMapper.RefinementstationTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, nameof (RefinementstationTarget));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationSubMenuMapper.RefinementstationTarget>.NativeClassPtr);
        RefinementstationSubMenuMapper.RefinementstationTarget.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper.RefinementstationTarget>.NativeClassPtr, nameof (Target));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefinementstationSubMenuMapper.RefinementstationTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.RefinementstationSubMenuMapper/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_getOutputItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRequirements;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_RefinementstationSubMenu_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244274, XrefRangeEnd = 1244448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity menuEntity, RefinementstationSubMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &menuEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_RefinementstationSubMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefinementstationSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr);
        RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (gameDataSystem));
        RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getOutputItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (getOutputItems));
        RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (getRequirements));
        RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, nameof (serverTime));
        RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, 100666228);
        RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_RefinementstationSubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefinementstationSubMenuMapper.__c__DisplayClass11_0>.NativeClassPtr, 100666229);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe RefinementstationSubMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RefinementstationSubMenuMapper) null : new RefinementstationSubMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BufferFromEntity<RecipeOutputBuffer> getOutputItems
      {
        get
        {
          return *(BufferFromEntity<RecipeOutputBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getOutputItems));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getOutputItems), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<RecipeOutputBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<RecipeRequirementBuffer> getRequirements
      {
        get
        {
          return *(BufferFromEntity<RecipeRequirementBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getRequirements));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_getRequirements), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<RecipeRequirementBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RefinementstationSubMenuMapper.__c__DisplayClass11_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }
    }
  }
}
