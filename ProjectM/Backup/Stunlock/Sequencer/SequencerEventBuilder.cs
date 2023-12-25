// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerEventBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  public class SequencerEventBuilder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndexOfType;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInfiniteDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayOnStealthedUnits;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertParameter_Protected_Static_Void_byref_BlackboardParameterBuilder_BlackboardBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrAddDynamicBuffer_Protected_DynamicBuffer_1_T_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAssetReference_Public_Int32_EntityManager_Entity_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeType_Public_Abstract_Virtual_New_NodeTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugName_Public_Abstract_Virtual_New_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(77)]
    [CachedScanResults(RefRangeStart = 923505, RefRangeEnd = 923582, XrefRangeStart = 923504, XrefRangeEnd = 923505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ConvertParameter(
      ref BlackboardParameterBuilder parameter,
      BlackboardBuilder blackboardBuilder)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) parameter);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerEventBuilder.NativeMethodInfoPtr_ConvertParameter_Protected_Static_Void_byref_BlackboardParameterBuilder_BlackboardBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe DynamicBuffer<T> GetOrAddDynamicBuffer<T>(
      EntityManager entityManager,
      Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequencerEventBuilder.MethodInfoStoreGeneric_GetOrAddDynamicBuffer_Protected_DynamicBuffer_1_T_EntityManager_Entity_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 923611, RefRangeEnd = 923615, XrefRangeStart = 923582, XrefRangeEnd = 923611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int AddAssetReference(EntityManager entityManager, Entity entity, UnityEngine.Object asset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequencerEventBuilder.NativeMethodInfoPtr_AddAssetReference_Public_Int32_EntityManager_Entity_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe NodeTypeEnum GetNodeType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Abstract_Virtual_New_NodeTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NodeTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager entityManager,
      BlackboardBuilder blackboardBuilder,
      SequenceEditorObject sequenceEditorObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceEditorObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe string GetDebugName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequencerEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequencerEventBuilder()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequencerEventBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequencerEventBuilder()
    {
      Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (SequencerEventBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr);
      SequencerEventBuilder.NativeFieldInfoPtr_DurationParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, nameof (DurationParameter));
      SequencerEventBuilder.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, nameof (NodeIndex));
      SequencerEventBuilder.NativeFieldInfoPtr_NodeIndexOfType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, nameof (NodeIndexOfType));
      SequencerEventBuilder.NativeFieldInfoPtr_IsInfiniteDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, nameof (IsInfiniteDuration));
      SequencerEventBuilder.NativeFieldInfoPtr_PlayOnStealthedUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, nameof (PlayOnStealthedUnits));
      SequencerEventBuilder.NativeMethodInfoPtr_ConvertParameter_Protected_Static_Void_byref_BlackboardParameterBuilder_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, 100663890);
      SequencerEventBuilder.NativeMethodInfoPtr_GetOrAddDynamicBuffer_Protected_DynamicBuffer_1_T_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, 100663891);
      SequencerEventBuilder.NativeMethodInfoPtr_AddAssetReference_Public_Int32_EntityManager_Entity_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, 100663892);
      SequencerEventBuilder.NativeMethodInfoPtr_GetNodeType_Public_Abstract_Virtual_New_NodeTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, 100663893);
      SequencerEventBuilder.NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_Entity_EntityManager_BlackboardBuilder_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, 100663894);
      SequencerEventBuilder.NativeMethodInfoPtr_GetDebugName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, 100663895);
      SequencerEventBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr, 100663896);
    }

    public SequencerEventBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterBuilder DurationParameter
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_DurationParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_DurationParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int NodeIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_NodeIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_NodeIndex)) = value;
      }
    }

    public unsafe int NodeIndexOfType
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_NodeIndexOfType));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_NodeIndexOfType)) = value;
      }
    }

    public unsafe bool IsInfiniteDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_IsInfiniteDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_IsInfiniteDuration)) = value;
      }
    }

    public unsafe bool PlayOnStealthedUnits
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_PlayOnStealthedUnits));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequencerEventBuilder.NativeFieldInfoPtr_PlayOnStealthedUnits)) = value;
      }
    }

    private sealed class MethodInfoStoreGeneric_GetOrAddDynamicBuffer_Protected_DynamicBuffer_1_T_EntityManager_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequencerEventBuilder.NativeMethodInfoPtr_GetOrAddDynamicBuffer_Protected_DynamicBuffer_1_T_EntityManager_Entity_0, Il2CppClassPointerStore<SequencerEventBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
