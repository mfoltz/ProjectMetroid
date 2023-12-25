// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequenceBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  public class SequenceBuilder : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceAssetGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardBuilder;
    private static readonly System.IntPtr NativeFieldInfoPtr_RootNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayInFlyMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayOnStealthedUnits;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConversionDependencies;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FlowEventBuilder_BlackboardBuilder_Boolean_Boolean_HashSet_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildSequence_Public_Il2CppReferenceArray_1_SequencerEventBuilder_EntityManager_Entity_String_SequenceEditorObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEventsOfType_Private_Static_List_1_T_List_1_SequencerEventBuilder_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923744, XrefRangeEnd = 923749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceBuilder(
      string sequenceAssetGuid,
      FlowEventBuilder rootNode,
      BlackboardBuilder blackboardBuilder,
      bool playInFlyMode,
      bool playOnStealthedUnits,
      HashSet<UnityEngine.Object> conversionDependencies)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sequenceAssetGuid);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootNode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &playInFlyMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &playOnStealthedUnits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionDependencies);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_FlowEventBuilder_BlackboardBuilder_Boolean_Boolean_HashSet_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 924171, RefRangeEnd = 924172, XrefRangeStart = 923749, XrefRangeEnd = 924171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<SequencerEventBuilder> BuildSequence(
      EntityManager entityManager,
      Entity entity,
      string sequenceName,
      SequenceEditorObject sequenceEditorObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceEditorObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_BuildSequence_Public_Il2CppReferenceArray_1_SequencerEventBuilder_EntityManager_Entity_String_SequenceEditorObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SequencerEventBuilder>) null : new Il2CppReferenceArray<SequencerEventBuilder>(nativeObject);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 924194, RefRangeEnd = 924208, XrefRangeStart = 924172, XrefRangeEnd = 924194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<T> GetEventsOfType<T>(List<SequencerEventBuilder> sequencerEvents) where T : SequencerEventBuilder
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequencerEvents);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_GetEventsOfType_Private_Static_List_1_T_List_1_SequencerEventBuilder_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
    }

    static SequenceBuilder()
    {
      Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (SequenceBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr);
      SequenceBuilder.NativeFieldInfoPtr_SequenceAssetGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, nameof (SequenceAssetGuid));
      SequenceBuilder.NativeFieldInfoPtr_BlackboardBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, nameof (BlackboardBuilder));
      SequenceBuilder.NativeFieldInfoPtr_RootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, nameof (RootNode));
      SequenceBuilder.NativeFieldInfoPtr_PlayInFlyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, nameof (PlayInFlyMode));
      SequenceBuilder.NativeFieldInfoPtr_PlayOnStealthedUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, nameof (PlayOnStealthedUnits));
      SequenceBuilder.NativeFieldInfoPtr_ConversionDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, nameof (ConversionDependencies));
      SequenceBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_FlowEventBuilder_BlackboardBuilder_Boolean_Boolean_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100663915);
      SequenceBuilder.NativeMethodInfoPtr_BuildSequence_Public_Il2CppReferenceArray_1_SequencerEventBuilder_EntityManager_Entity_String_SequenceEditorObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100663916);
      SequenceBuilder.NativeMethodInfoPtr_GetEventsOfType_Private_Static_List_1_T_List_1_SequencerEventBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100663917);
    }

    public SequenceBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string SequenceAssetGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_SequenceAssetGuid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_SequenceAssetGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe BlackboardBuilder BlackboardBuilder
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_BlackboardBuilder));
        return pointer == System.IntPtr.Zero ? (BlackboardBuilder) null : new BlackboardBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_BlackboardBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FlowEventBuilder RootNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_RootNode));
        return pointer == System.IntPtr.Zero ? (FlowEventBuilder) null : new FlowEventBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_RootNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool PlayInFlyMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_PlayInFlyMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_PlayInFlyMode)) = value;
      }
    }

    public unsafe bool PlayOnStealthedUnits
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_PlayOnStealthedUnits));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_PlayOnStealthedUnits)) = value;
      }
    }

    public unsafe HashSet<UnityEngine.Object> ConversionDependencies
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_ConversionDependencies));
        return pointer == System.IntPtr.Zero ? (HashSet<UnityEngine.Object>) null : new HashSet<UnityEngine.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_ConversionDependencies), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_GetEventsOfType_Private_Static_List_1_T_List_1_SequencerEventBuilder_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_GetEventsOfType_Private_Static_List_1_T_List_1_SequencerEventBuilder_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
