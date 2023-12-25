// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityDiffTracking
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class EntityDiffTracking : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__States;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Static_String_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dump_Public_Static_String_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Static_String_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendEntities_Public_Static_Void_StringBuilder_List_1_Entity_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpInternal_Private_Static_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntities_Private_Static_NativeArray_1_Entity_World_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Bump_Private_Static_Void_Dictionary_2_T_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ArchetypeToString_Private_Static_String_EntityArchetype_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994153, XrefRangeEnd = 994174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Start(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.NativeMethodInfoPtr_Start_Public_Static_String_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994174, XrefRangeEnd = 994186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Dump(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.NativeMethodInfoPtr_Dump_Public_Static_String_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994186, XrefRangeEnd = 994209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string End(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.NativeMethodInfoPtr_End_Public_Static_String_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994331, RefRangeEnd = 994332, XrefRangeStart = 994209, XrefRangeEnd = 994331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendEntities(
      StringBuilder builder,
      List<Entity> entities,
      World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entities);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.NativeMethodInfoPtr_AppendEntities_Public_Static_Void_StringBuilder_List_1_Entity_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994406, RefRangeEnd = 994408, XrefRangeStart = 994332, XrefRangeEnd = 994406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpInternal(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.NativeMethodInfoPtr_DumpInternal_Private_Static_Void_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 994420, RefRangeEnd = 994422, XrefRangeStart = 994408, XrefRangeEnd = 994420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeArray<Entity> GetEntities(World world, Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.NativeMethodInfoPtr_GetEntities_Private_Static_NativeArray_1_Entity_World_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994425, RefRangeEnd = 994426, XrefRangeStart = 994422, XrefRangeEnd = 994425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Bump<T>(Dictionary<T, int> dictionary, T item)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dictionary);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) item;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref item;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.MethodInfoStoreGeneric_Bump_Private_Static_Void_Dictionary_2_T_Int32_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 994454, RefRangeEnd = 994455, XrefRangeStart = 994426, XrefRangeEnd = 994454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ArchetypeToString(EntityArchetype archetype)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &archetype;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.NativeMethodInfoPtr_ArchetypeToString_Private_Static_String_EntityArchetype_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static EntityDiffTracking()
    {
      Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EntityDiffTracking));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr);
      EntityDiffTracking.NativeFieldInfoPtr__States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, nameof (_States));
      EntityDiffTracking.NativeMethodInfoPtr_Start_Public_Static_String_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676769);
      EntityDiffTracking.NativeMethodInfoPtr_Dump_Public_Static_String_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676770);
      EntityDiffTracking.NativeMethodInfoPtr_End_Public_Static_String_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676771);
      EntityDiffTracking.NativeMethodInfoPtr_AppendEntities_Public_Static_Void_StringBuilder_List_1_Entity_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676772);
      EntityDiffTracking.NativeMethodInfoPtr_DumpInternal_Private_Static_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676773);
      EntityDiffTracking.NativeMethodInfoPtr_GetEntities_Private_Static_NativeArray_1_Entity_World_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676774);
      EntityDiffTracking.NativeMethodInfoPtr_Bump_Private_Static_Void_Dictionary_2_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676775);
      EntityDiffTracking.NativeMethodInfoPtr_ArchetypeToString_Private_Static_String_EntityArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, 100676776);
    }

    public EntityDiffTracking(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Dictionary<World, EntityDiffTracking.State> _States
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EntityDiffTracking.NativeFieldInfoPtr__States, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<World, EntityDiffTracking.State>) null : new Dictionary<World, EntityDiffTracking.State>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EntityDiffTracking.NativeFieldInfoPtr__States, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class State : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StartEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe State()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityDiffTracking.State>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.State.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static State()
      {
        Il2CppClassPointerStore<EntityDiffTracking.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, nameof (State));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDiffTracking.State>.NativeClassPtr);
        EntityDiffTracking.State.NativeFieldInfoPtr_StartEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDiffTracking.State>.NativeClassPtr, nameof (StartEntities));
        EntityDiffTracking.State.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDiffTracking.State>.NativeClassPtr, nameof (StartTime));
        EntityDiffTracking.State.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking.State>.NativeClassPtr, 100676778);
      }

      public State(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe NativeArray<Entity> StartEntities
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityDiffTracking.State.NativeFieldInfoPtr_StartEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityDiffTracking.State.NativeFieldInfoPtr_StartEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe float StartTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityDiffTracking.State.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityDiffTracking.State.NativeFieldInfoPtr_StartTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.EntityDiffTracking/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AppendEntities_b__0_Internal___f__AnonymousType0_2_String_Int32_KeyValuePair_Unboxed_2_PrefabGUID_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityDiffTracking.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994128, XrefRangeEnd = 994140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __f__AnonymousType0<string, int> _AppendEntities_b__0(
        KeyValuePair_Unboxed<PrefabGUID, int> entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entry;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.__c__DisplayClass5_0.NativeMethodInfoPtr__AppendEntities_b__0_Internal___f__AnonymousType0_2_String_Int32_KeyValuePair_Unboxed_2_PrefabGUID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (__f__AnonymousType0<string, int>) null : new __f__AnonymousType0<string, int>(pointer);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<EntityDiffTracking.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDiffTracking.__c__DisplayClass5_0>.NativeClassPtr);
        EntityDiffTracking.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDiffTracking.__c__DisplayClass5_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        EntityDiffTracking.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking.__c__DisplayClass5_0>.NativeClassPtr, 100676779);
        EntityDiffTracking.__c__DisplayClass5_0.NativeMethodInfoPtr__AppendEntities_b__0_Internal___f__AnonymousType0_2_String_Int32_KeyValuePair_Unboxed_2_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking.__c__DisplayClass5_0>.NativeClassPtr, 100676780);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityDiffTracking.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntityDiffTracking.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EntityDiffTracking/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AppendEntities_b__5_1_Internal___f__AnonymousType0_2_String_Int32_KeyValuePair_Unboxed_2_EntityArchetype_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AppendEntities_b__5_2_Internal_Int32___f__AnonymousType0_2_String_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994140, XrefRangeEnd = 994152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __f__AnonymousType0<string, int> _AppendEntities_b__5_1(
        KeyValuePair_Unboxed<EntityArchetype, int> entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entry;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.__c.NativeMethodInfoPtr__AppendEntities_b__5_1_Internal___f__AnonymousType0_2_String_Int32_KeyValuePair_Unboxed_2_EntityArchetype_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (__f__AnonymousType0<string, int>) null : new __f__AnonymousType0<string, int>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994152, XrefRangeEnd = 994153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _AppendEntities_b__5_2(__f__AnonymousType0<string, int> entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDiffTracking.__c.NativeMethodInfoPtr__AppendEntities_b__5_2_Internal_Int32___f__AnonymousType0_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr);
        EntityDiffTracking.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr, "<>9");
        EntityDiffTracking.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr, "<>9__5_1");
        EntityDiffTracking.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr, "<>9__5_2");
        EntityDiffTracking.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr, 100676782);
        EntityDiffTracking.__c.NativeMethodInfoPtr__AppendEntities_b__5_1_Internal___f__AnonymousType0_2_String_Int32_KeyValuePair_Unboxed_2_EntityArchetype_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr, 100676783);
        EntityDiffTracking.__c.NativeMethodInfoPtr__AppendEntities_b__5_2_Internal_Int32___f__AnonymousType0_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDiffTracking.__c>.NativeClassPtr, 100676784);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe EntityDiffTracking.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EntityDiffTracking.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (EntityDiffTracking.__c) null : new EntityDiffTracking.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EntityDiffTracking.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, int>, __f__AnonymousType0<string, int>> __9__5_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EntityDiffTracking.__c.NativeFieldInfoPtr___9__5_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, int>, __f__AnonymousType0<string, int>>) null : new Il2CppSystem.Func<KeyValuePair_Unboxed<EntityArchetype, int>, __f__AnonymousType0<string, int>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EntityDiffTracking.__c.NativeFieldInfoPtr___9__5_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType0<string, int>, int> __9__5_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EntityDiffTracking.__c.NativeFieldInfoPtr___9__5_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType0<string, int>, int>) null : new Il2CppSystem.Func<__f__AnonymousType0<string, int>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EntityDiffTracking.__c.NativeFieldInfoPtr___9__5_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_Bump_Private_Static_Void_Dictionary_2_T_Int32_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(EntityDiffTracking.NativeMethodInfoPtr_Bump_Private_Static_Void_Dictionary_2_T_Int32_T_0, Il2CppClassPointerStore<EntityDiffTracking>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
