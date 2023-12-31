// Decompiled with JetBrains decompiler
// Type: ProjectM.StaticTransformIndexConversion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class StaticTransformIndexConversion : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RequiredTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedIndexLookup;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindStaticTransforms_Private_Void_List_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddConversionEntities_Private_Void_List_1_GameObject_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTransformLookupType_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStaticTransformIndex_Public_Boolean_GameObject_byref_StaticTransformIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762400, XrefRangeEnd = 762487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StaticTransformIndexConversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762545, RefRangeEnd = 762546, XrefRangeStart = 762487, XrefRangeEnd = 762545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FindStaticTransforms(List<GameObject> staticTransforms)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) staticTransforms);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexConversion.NativeMethodInfoPtr_FindStaticTransforms_Private_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762576, RefRangeEnd = 762577, XrefRangeStart = 762546, XrefRangeEnd = 762576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddConversionEntities(List<GameObject> staticTransforms, Il2CppSystem.Type componentType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) staticTransforms);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentType);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexConversion.NativeMethodInfoPtr_AddConversionEntities_Private_Void_List_1_GameObject_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 762590, RefRangeEnd = 762594, XrefRangeStart = 762577, XrefRangeEnd = 762590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterTransformLookupType<T>() where T : Component
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexConversion.MethodInfoStoreGeneric_RegisterTransformLookupType_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 762597, RefRangeEnd = 762603, XrefRangeStart = 762594, XrefRangeEnd = 762597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetStaticTransformIndex(
      GameObject gameObject,
      out StaticTransformIndex transformIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref transformIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexConversion.NativeMethodInfoPtr_TryGetStaticTransformIndex_Public_Boolean_GameObject_byref_StaticTransformIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762603, XrefRangeEnd = 762618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StaticTransformIndexConversion()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexConversion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StaticTransformIndexConversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StaticTransformIndexConversion()
    {
      Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StaticTransformIndexConversion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr);
      StaticTransformIndexConversion.NativeFieldInfoPtr__RequiredTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, nameof (_RequiredTypes));
      StaticTransformIndexConversion.NativeFieldInfoPtr_NetworkedIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, nameof (NetworkedIndexLookup));
      StaticTransformIndexConversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, 100667378);
      StaticTransformIndexConversion.NativeMethodInfoPtr_FindStaticTransforms_Private_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, 100667379);
      StaticTransformIndexConversion.NativeMethodInfoPtr_AddConversionEntities_Private_Void_List_1_GameObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, 100667380);
      StaticTransformIndexConversion.NativeMethodInfoPtr_RegisterTransformLookupType_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, 100667381);
      StaticTransformIndexConversion.NativeMethodInfoPtr_TryGetStaticTransformIndex_Public_Boolean_GameObject_byref_StaticTransformIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, 100667382);
      StaticTransformIndexConversion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, 100667383);
      StaticTransformIndexConversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, 100667384);
    }

    public StaticTransformIndexConversion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Il2CppSystem.Type> _RequiredTypes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.NativeFieldInfoPtr__RequiredTypes));
        return pointer == System.IntPtr.Zero ? (List<Il2CppSystem.Type>) null : new List<Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.NativeFieldInfoPtr__RequiredTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<GameObject, StaticTransformIndexConversion.StaticTransformLookup> NetworkedIndexLookup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.NativeFieldInfoPtr_NetworkedIndexLookup));
        return pointer == System.IntPtr.Zero ? (Dictionary<GameObject, StaticTransformIndexConversion.StaticTransformLookup>) null : new Dictionary<GameObject, StaticTransformIndexConversion.StaticTransformLookup>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.NativeFieldInfoPtr_NetworkedIndexLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class SortableStaticTransform : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TRS;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameObject;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SortableStaticTransform_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IEquatable_ProjectM_StaticTransformIndexConversion_SortableStaticTransform__Equals_Private_Virtual_Final_New_Boolean_SortableStaticTransform_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762390, XrefRangeEnd = 762400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        StaticTransformIndexConversion.SortableStaticTransform other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexConversion.SortableStaticTransform.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SortableStaticTransform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public virtual unsafe bool System_IEquatable_ProjectM_StaticTransformIndexConversion_SortableStaticTransform__Equals(
        StaticTransformIndexConversion.SortableStaticTransform other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexConversion.SortableStaticTransform.NativeMethodInfoPtr_System_IEquatable_ProjectM_StaticTransformIndexConversion_SortableStaticTransform__Equals_Private_Virtual_Final_New_Boolean_SortableStaticTransform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SortableStaticTransform()
      {
        Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, nameof (SortableStaticTransform));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr);
        StaticTransformIndexConversion.SortableStaticTransform.NativeFieldInfoPtr_TRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr, nameof (TRS));
        StaticTransformIndexConversion.SortableStaticTransform.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr, nameof (GameObject));
        StaticTransformIndexConversion.SortableStaticTransform.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SortableStaticTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr, 100667385);
        StaticTransformIndexConversion.SortableStaticTransform.NativeMethodInfoPtr_System_IEquatable_ProjectM_StaticTransformIndexConversion_SortableStaticTransform__Equals_Private_Virtual_Final_New_Boolean_SortableStaticTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr, 100667386);
      }

      public SortableStaticTransform(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SortableStaticTransform()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticTransformIndexConversion.SortableStaticTransform>.NativeClassPtr, data));
      }

      public unsafe float4x4 TRS
      {
        get
        {
          return *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.SortableStaticTransform.NativeFieldInfoPtr_TRS));
        }
        [param: In] set
        {
          *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.SortableStaticTransform.NativeFieldInfoPtr_TRS)) = value;
        }
      }

      public unsafe GameObject GameObject
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.SortableStaticTransform.NativeFieldInfoPtr_GameObject));
          return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.SortableStaticTransform.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class StaticTransformLookup : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LookupIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSceneId;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameObject;

      static StaticTransformLookup()
      {
        Il2CppClassPointerStore<StaticTransformIndexConversion.StaticTransformLookup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr, nameof (StaticTransformLookup));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformIndexConversion.StaticTransformLookup>.NativeClassPtr);
        StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_LookupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexConversion.StaticTransformLookup>.NativeClassPtr, nameof (LookupIndex));
        StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_ChunkSceneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexConversion.StaticTransformLookup>.NativeClassPtr, nameof (ChunkSceneId));
        StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexConversion.StaticTransformLookup>.NativeClassPtr, nameof (GameObject));
      }

      public StaticTransformLookup(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public StaticTransformLookup()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StaticTransformIndexConversion.StaticTransformLookup>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticTransformIndexConversion.StaticTransformLookup>.NativeClassPtr, data));
      }

      public unsafe int LookupIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_LookupIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_LookupIndex)) = value;
        }
      }

      public unsafe ChunkSceneId ChunkSceneId
      {
        get
        {
          return *(ChunkSceneId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_ChunkSceneId));
        }
        [param: In] set
        {
          *(ChunkSceneId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_ChunkSceneId)) = value;
        }
      }

      public unsafe GameObject GameObject
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_GameObject));
          return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StaticTransformIndexConversion.StaticTransformLookup.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_RegisterTransformLookupType_Public_Void_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(StaticTransformIndexConversion.NativeMethodInfoPtr_RegisterTransformLookupType_Public_Void_0, Il2CppClassPointerStore<StaticTransformIndexConversion>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
