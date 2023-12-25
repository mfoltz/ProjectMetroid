// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialPropertySystem_Dots
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  public class MaterialPropertySystem_Dots : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesAndDataIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChangeData;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsedThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__UsedLastFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddChange_Public_Void_Entity_Int32_byref_ChangeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendChangesToFusedChildren_Private_Static_Void_EntityManager_Entity_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetComponentAndAddIfMissing_Private_Void_Entity_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102746, XrefRangeEnd = 1102772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1102782, RefRangeEnd = 1102783, XrefRangeStart = 1102772, XrefRangeEnd = 1102782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddChange(Entity entity, int importance, [In] ref ChangeData change)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &importance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref change;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Dots.NativeMethodInfoPtr_AddChange_Public_Void_Entity_Int32_byref_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1102818, RefRangeEnd = 1102820, XrefRangeStart = 1102783, XrefRangeEnd = 1102818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendChangesToFusedChildren(
      EntityManager entityManager,
      Entity entity,
      float4 changeValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &changeValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Dots.NativeMethodInfoPtr_SendChangesToFusedChildren_Private_Static_Void_EntityManager_Entity_float4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102820, XrefRangeEnd = 1102974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1103079, RefRangeEnd = 1103081, XrefRangeStart = 1102974, XrefRangeEnd = 1103079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetComponentAndAddIfMissing<T>(Entity entity, T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Dots.MethodInfoStoreGeneric_SetComponentAndAddIfMissing_Private_Void_Entity_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialPropertySystem_Dots()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialPropertySystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialPropertySystem_Dots()
    {
      Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialPropertySystem_Dots));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr);
      MaterialPropertySystem_Dots.NativeFieldInfoPtr__EntitiesAndDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, nameof (_EntitiesAndDataIndex));
      MaterialPropertySystem_Dots.NativeFieldInfoPtr__ChangeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, nameof (_ChangeData));
      MaterialPropertySystem_Dots.NativeFieldInfoPtr__UsedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, nameof (_UsedThisFrame));
      MaterialPropertySystem_Dots.NativeFieldInfoPtr__UsedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, nameof (_UsedLastFrame));
      MaterialPropertySystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, 100687500);
      MaterialPropertySystem_Dots.NativeMethodInfoPtr_AddChange_Public_Void_Entity_Int32_byref_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, 100687501);
      MaterialPropertySystem_Dots.NativeMethodInfoPtr_SendChangesToFusedChildren_Private_Static_Void_EntityManager_Entity_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, 100687502);
      MaterialPropertySystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, 100687503);
      MaterialPropertySystem_Dots.NativeMethodInfoPtr_SetComponentAndAddIfMissing_Private_Void_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, 100687504);
      MaterialPropertySystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, 100687505);
      MaterialPropertySystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, 100687506);
    }

    public MaterialPropertySystem_Dots(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<MaterialPropertySystem_Dots.EntityAndDataIndex> _EntitiesAndDataIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__EntitiesAndDataIndex));
        return pointer == System.IntPtr.Zero ? (List<MaterialPropertySystem_Dots.EntityAndDataIndex>) null : new List<MaterialPropertySystem_Dots.EntityAndDataIndex>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__EntitiesAndDataIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ChangeData> _ChangeData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__ChangeData));
        return pointer == System.IntPtr.Zero ? (List<ChangeData>) null : new List<ChangeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__ChangeData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<MaterialPropertySystem_Dots.LastFrameEntry> _UsedThisFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__UsedThisFrame));
        return pointer == System.IntPtr.Zero ? (HashSet<MaterialPropertySystem_Dots.LastFrameEntry>) null : new HashSet<MaterialPropertySystem_Dots.LastFrameEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__UsedThisFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<MaterialPropertySystem_Dots.LastFrameEntry> _UsedLastFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__UsedLastFrame));
        return pointer == System.IntPtr.Zero ? (HashSet<MaterialPropertySystem_Dots.LastFrameEntry>) null : new HashSet<MaterialPropertySystem_Dots.LastFrameEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertySystem_Dots.NativeFieldInfoPtr__UsedLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityAndDataIndex
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_DataIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EntityAndDataIndex_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public int DataIndex;
      [FieldOffset(12)]
      public int Importance;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102740, XrefRangeEnd = 1102742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        MaterialPropertySystem_Dots.EntityAndDataIndex other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Dots.EntityAndDataIndex.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EntityAndDataIndex_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static EntityAndDataIndex()
      {
        Il2CppClassPointerStore<MaterialPropertySystem_Dots.EntityAndDataIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, nameof (EntityAndDataIndex));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertySystem_Dots.EntityAndDataIndex>.NativeClassPtr);
        MaterialPropertySystem_Dots.EntityAndDataIndex.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots.EntityAndDataIndex>.NativeClassPtr, nameof (Entity));
        MaterialPropertySystem_Dots.EntityAndDataIndex.NativeFieldInfoPtr_DataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots.EntityAndDataIndex>.NativeClassPtr, nameof (DataIndex));
        MaterialPropertySystem_Dots.EntityAndDataIndex.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots.EntityAndDataIndex>.NativeClassPtr, nameof (Importance));
        MaterialPropertySystem_Dots.EntityAndDataIndex.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EntityAndDataIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots.EntityAndDataIndex>.NativeClassPtr, 100687507);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialPropertySystem_Dots.EntityAndDataIndex>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LastFrameEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomProperty;
      private static readonly System.IntPtr NativeFieldInfoPtr_Property;
      private static readonly System.IntPtr NativeFieldInfoPtr_PropertyId;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LastFrameEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public bool UseCustomProperty;
      [FieldOffset(12)]
      public SupportedDotsProperty Property;
      [FieldOffset(16)]
      public int PropertyId;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102742, XrefRangeEnd = 1102743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(MaterialPropertySystem_Dots.LastFrameEntry other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Dots.LastFrameEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LastFrameEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102743, XrefRangeEnd = 1102746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialPropertySystem_Dots.LastFrameEntry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LastFrameEntry()
      {
        Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr, nameof (LastFrameEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr);
        MaterialPropertySystem_Dots.LastFrameEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr, nameof (Entity));
        MaterialPropertySystem_Dots.LastFrameEntry.NativeFieldInfoPtr_UseCustomProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr, nameof (UseCustomProperty));
        MaterialPropertySystem_Dots.LastFrameEntry.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr, nameof (Property));
        MaterialPropertySystem_Dots.LastFrameEntry.NativeFieldInfoPtr_PropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr, nameof (PropertyId));
        MaterialPropertySystem_Dots.LastFrameEntry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LastFrameEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr, 100687508);
        MaterialPropertySystem_Dots.LastFrameEntry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr, 100687509);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialPropertySystem_Dots.LastFrameEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_SetComponentAndAddIfMissing_Private_Void_Entity_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MaterialPropertySystem_Dots.NativeMethodInfoPtr_SetComponentAndAddIfMissing_Private_Void_Entity_T_0, Il2CppClassPointerStore<MaterialPropertySystem_Dots>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
