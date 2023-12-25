// Decompiled with JetBrains decompiler
// Type: ProjectM.NativeMemoryAnalysis
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class NativeMemoryAnalysis : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LENGTH_STRING;
    private static readonly System.IntPtr NativeFieldInfoPtr_COUNT_STRING;
    private static readonly System.IntPtr NativeFieldInfoPtr_CAPACITY_STRING;
    private static readonly System.IntPtr NativeFieldInfoPtr_EMPTY_ITEM_LIST;
    private static readonly System.IntPtr NativeFieldInfoPtr_UNITY_SYSTEM_TYPES;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnalyzeBlobAssets_Public_Static_List_1_BlobMemoryData_World_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RecursiveFindBlobAssetReferences_Private_Static_Void_Type_Int32_List_1_BlobField_HashSet_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnalyzeDynamicBuffers_Public_Static_List_1_BufferMemoryData_World_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnalyzeComponents_Public_Static_List_1_ComponentDump_World_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFieldsIncludeBaseTypes_Private_Static_Void_Type_List_1_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnalyzeSystemCollections_Public_Static_List_1_Item_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnalyzeField_Private_Static_List_1_Item_FieldInfo_Object_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnalyzeGenericField_Private_Static_Item_FieldInfo_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCountMethod_Private_Static_Int32_Type_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateHashMapSize_Private_Static_Int32_Int32_Type_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOfType_Private_Static_Boolean_Type_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SizeOfGenericArgument_Private_Static_Int32_Type_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SizeOf_Private_Static_Int32_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Type_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1648859, RefRangeEnd = 1648860, XrefRangeStart = 1648744, XrefRangeEnd = 1648859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<NativeMemoryAnalysis.BlobMemoryData> AnalyzeBlobAssets(
      World world,
      out int totalSizeBytes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalSizeBytes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeBlobAssets_Public_Static_List_1_BlobMemoryData_World_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<NativeMemoryAnalysis.BlobMemoryData>) null : new List<NativeMemoryAnalysis.BlobMemoryData>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1648887, RefRangeEnd = 1648889, XrefRangeStart = 1648860, XrefRangeEnd = 1648887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RecursiveFindBlobAssetReferences(
      Il2CppSystem.Type type,
      int offsetFromBase,
      List<NativeMemoryAnalysis.BlobField> blobFields,
      HashSet<Il2CppSystem.Type> alreadyVisitedTypes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetFromBase;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blobFields);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyVisitedTypes);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_RecursiveFindBlobAssetReferences_Private_Static_Void_Type_Int32_List_1_BlobField_HashSet_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1648939, RefRangeEnd = 1648940, XrefRangeStart = 1648889, XrefRangeEnd = 1648939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<NativeMemoryAnalysis.BufferMemoryData> AnalyzeDynamicBuffers(
      World world,
      out long totalSizeBytes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalSizeBytes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeDynamicBuffers_Public_Static_List_1_BufferMemoryData_World_byref_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<NativeMemoryAnalysis.BufferMemoryData>) null : new List<NativeMemoryAnalysis.BufferMemoryData>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1649000, RefRangeEnd = 1649001, XrefRangeStart = 1648940, XrefRangeEnd = 1649000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<NativeMemoryAnalysis.ComponentDump> AnalyzeComponents(
      World world,
      out long totalSizeBytes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalSizeBytes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeComponents_Public_Static_List_1_ComponentDump_World_byref_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<NativeMemoryAnalysis.ComponentDump>) null : new List<NativeMemoryAnalysis.ComponentDump>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1649018, RefRangeEnd = 1649019, XrefRangeStart = 1649001, XrefRangeEnd = 1649018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetFieldsIncludeBaseTypes(Il2CppSystem.Type type, List<FieldInfo> fields)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fields);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_GetFieldsIncludeBaseTypes_Private_Static_Void_Type_List_1_FieldInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1649096, RefRangeEnd = 1649097, XrefRangeStart = 1649019, XrefRangeEnd = 1649096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<NativeMemoryAnalysis.Item> AnalyzeSystemCollections(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeSystemCollections_Public_Static_List_1_Item_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<NativeMemoryAnalysis.Item>) null : new List<NativeMemoryAnalysis.Item>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1649162, RefRangeEnd = 1649164, XrefRangeStart = 1649097, XrefRangeEnd = 1649162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe List<NativeMemoryAnalysis.Item> AnalyzeField(
      FieldInfo field,
      Il2CppSystem.Object parentInstance,
      int depth)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentInstance);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeField_Private_Static_List_1_Item_FieldInfo_Object_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<NativeMemoryAnalysis.Item>) null : new List<NativeMemoryAnalysis.Item>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1649312, RefRangeEnd = 1649313, XrefRangeStart = 1649164, XrefRangeEnd = 1649312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeMemoryAnalysis.Item AnalyzeGenericField(
      FieldInfo field,
      Il2CppSystem.Object fieldInstance)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fieldInstance);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeGenericField_Private_Static_Item_FieldInfo_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (NativeMemoryAnalysis.Item) null : new NativeMemoryAnalysis.Item(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649313, XrefRangeEnd = 1649322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int InvokeCountMethod(Il2CppSystem.Type type, Il2CppSystem.Object instance)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_InvokeCountMethod_Private_Static_Int32_Type_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649322, XrefRangeEnd = 1649331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int CalculateHashMapSize(int length, Il2CppSystem.Type keyType, Il2CppSystem.Type valueType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &length;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) valueType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_CalculateHashMapSize_Private_Static_Int32_Int32_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1649335, RefRangeEnd = 1649338, XrefRangeStart = 1649331, XrefRangeEnd = 1649335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsOfType(Il2CppSystem.Type a, Il2CppSystem.Type b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_IsOfType_Private_Static_Boolean_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649338, XrefRangeEnd = 1649345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int SizeOfGenericArgument(Il2CppSystem.Type type, int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_SizeOfGenericArgument_Private_Static_Int32_Type_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1649345, XrefRangeEnd = 1649346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int SizeOf(Il2CppSystem.Type type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_SizeOf_Private_Static_Int32_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1649364, RefRangeEnd = 1649367, XrefRangeStart = 1649346, XrefRangeEnd = 1649364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Method_Internal_Static_String_Type_0(Il2CppSystem.Type typeToFixNameFor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) typeToFixNameFor);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.NativeMethodInfoPtr_Method_Internal_Static_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static NativeMemoryAnalysis()
    {
      Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (NativeMemoryAnalysis));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr);
      NativeMemoryAnalysis.NativeFieldInfoPtr_LENGTH_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (LENGTH_STRING));
      NativeMemoryAnalysis.NativeFieldInfoPtr_COUNT_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (COUNT_STRING));
      NativeMemoryAnalysis.NativeFieldInfoPtr_CAPACITY_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (CAPACITY_STRING));
      NativeMemoryAnalysis.NativeFieldInfoPtr_EMPTY_ITEM_LIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (EMPTY_ITEM_LIST));
      NativeMemoryAnalysis.NativeFieldInfoPtr_UNITY_SYSTEM_TYPES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (UNITY_SYSTEM_TYPES));
      NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeBlobAssets_Public_Static_List_1_BlobMemoryData_World_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663806);
      NativeMemoryAnalysis.NativeMethodInfoPtr_RecursiveFindBlobAssetReferences_Private_Static_Void_Type_Int32_List_1_BlobField_HashSet_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663807);
      NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeDynamicBuffers_Public_Static_List_1_BufferMemoryData_World_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663808);
      NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeComponents_Public_Static_List_1_ComponentDump_World_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663809);
      NativeMemoryAnalysis.NativeMethodInfoPtr_GetFieldsIncludeBaseTypes_Private_Static_Void_Type_List_1_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663810);
      NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeSystemCollections_Public_Static_List_1_Item_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663811);
      NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeField_Private_Static_List_1_Item_FieldInfo_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663812);
      NativeMemoryAnalysis.NativeMethodInfoPtr_AnalyzeGenericField_Private_Static_Item_FieldInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663813);
      NativeMemoryAnalysis.NativeMethodInfoPtr_InvokeCountMethod_Private_Static_Int32_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663814);
      NativeMemoryAnalysis.NativeMethodInfoPtr_CalculateHashMapSize_Private_Static_Int32_Int32_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663815);
      NativeMemoryAnalysis.NativeMethodInfoPtr_IsOfType_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663816);
      NativeMemoryAnalysis.NativeMethodInfoPtr_SizeOfGenericArgument_Private_Static_Int32_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663817);
      NativeMemoryAnalysis.NativeMethodInfoPtr_SizeOf_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663818);
      NativeMemoryAnalysis.NativeMethodInfoPtr_Method_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, 100663820);
    }

    public NativeMemoryAnalysis(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string LENGTH_STRING
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(NativeMemoryAnalysis.NativeFieldInfoPtr_LENGTH_STRING, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NativeMemoryAnalysis.NativeFieldInfoPtr_LENGTH_STRING, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string COUNT_STRING
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(NativeMemoryAnalysis.NativeFieldInfoPtr_COUNT_STRING, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NativeMemoryAnalysis.NativeFieldInfoPtr_COUNT_STRING, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CAPACITY_STRING
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(NativeMemoryAnalysis.NativeFieldInfoPtr_CAPACITY_STRING, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NativeMemoryAnalysis.NativeFieldInfoPtr_CAPACITY_STRING, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe List<NativeMemoryAnalysis.Item> EMPTY_ITEM_LIST
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NativeMemoryAnalysis.NativeFieldInfoPtr_EMPTY_ITEM_LIST, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<NativeMemoryAnalysis.Item>) null : new List<NativeMemoryAnalysis.Item>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NativeMemoryAnalysis.NativeFieldInfoPtr_EMPTY_ITEM_LIST, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> UNITY_SYSTEM_TYPES
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NativeMemoryAnalysis.NativeFieldInfoPtr_UNITY_SYSTEM_TYPES, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NativeMemoryAnalysis.NativeFieldInfoPtr_UNITY_SYSTEM_TYPES, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class BlobMemoryData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BlobTypeName;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlobTypeFullName;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlobCount;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlobMemoryData_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648660, XrefRangeEnd = 1648662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(NativeMemoryAnalysis.BlobMemoryData other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.BlobMemoryData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlobMemoryData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static BlobMemoryData()
      {
        Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (BlobMemoryData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr);
        NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, nameof (BlobTypeName));
        NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobTypeFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, nameof (BlobTypeFullName));
        NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_TotalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, nameof (TotalSize));
        NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, nameof (MaxSize));
        NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, nameof (BlobCount));
        NativeMemoryAnalysis.BlobMemoryData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlobMemoryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, 100663821);
      }

      public BlobMemoryData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BlobMemoryData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobMemoryData>.NativeClassPtr, data));
      }

      public unsafe string BlobTypeName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobTypeName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string BlobTypeFullName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobTypeFullName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobTypeFullName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int TotalSize
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_TotalSize));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_TotalSize)) = value;
        }
      }

      public unsafe int MaxSize
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_MaxSize));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_MaxSize)) = value;
        }
      }

      public unsafe long BlobCount
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobCount));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobMemoryData.NativeFieldInfoPtr_BlobCount)) = value;
        }
      }
    }

    public sealed class BlobField : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BlobType;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlobFieldOffset;

      static BlobField()
      {
        Il2CppClassPointerStore<NativeMemoryAnalysis.BlobField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (BlobField));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobField>.NativeClassPtr);
        NativeMemoryAnalysis.BlobField.NativeFieldInfoPtr_BlobType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobField>.NativeClassPtr, nameof (BlobType));
        NativeMemoryAnalysis.BlobField.NativeFieldInfoPtr_BlobFieldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobField>.NativeClassPtr, nameof (BlobFieldOffset));
      }

      public BlobField(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BlobField()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobField>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeMemoryAnalysis.BlobField>.NativeClassPtr, data));
      }

      public unsafe Il2CppSystem.Type BlobType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobField.NativeFieldInfoPtr_BlobType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobField.NativeFieldInfoPtr_BlobType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int BlobFieldOffset
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobField.NativeFieldInfoPtr_BlobFieldOffset));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BlobField.NativeFieldInfoPtr_BlobFieldOffset)) = value;
        }
      }
    }

    public sealed class BufferMemoryData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BufferTypeName;
      private static readonly System.IntPtr NativeFieldInfoPtr_BufferTypeFullName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Size;
      private static readonly System.IntPtr NativeFieldInfoPtr_BufferCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_CapacityCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_ElementTotalSize;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BufferMemoryData_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648662, XrefRangeEnd = 1648664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(NativeMemoryAnalysis.BufferMemoryData other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.BufferMemoryData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BufferMemoryData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static BufferMemoryData()
      {
        Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (BufferMemoryData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr);
        NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, nameof (BufferTypeName));
        NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferTypeFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, nameof (BufferTypeFullName));
        NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, nameof (Size));
        NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, nameof (BufferCount));
        NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_ElementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, nameof (ElementCount));
        NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_CapacityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, nameof (CapacityCount));
        NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_ElementTotalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, nameof (ElementTotalSize));
        NativeMemoryAnalysis.BufferMemoryData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BufferMemoryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, 100663822);
      }

      public BufferMemoryData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BufferMemoryData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeMemoryAnalysis.BufferMemoryData>.NativeClassPtr, data));
      }

      public unsafe string BufferTypeName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferTypeName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string BufferTypeFullName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferTypeFullName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferTypeFullName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int Size
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_Size));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_Size)) = value;
        }
      }

      public unsafe long BufferCount
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferCount));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_BufferCount)) = value;
        }
      }

      public unsafe long ElementCount
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_ElementCount));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_ElementCount)) = value;
        }
      }

      public unsafe long CapacityCount
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_CapacityCount));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_CapacityCount)) = value;
        }
      }

      public unsafe long ElementTotalSize
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_ElementTotalSize));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.BufferMemoryData.NativeFieldInfoPtr_ElementTotalSize)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ComponentDump
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentTypeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalSize;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ComponentDump_0;
      [FieldOffset(0)]
      public int ComponentTypeIndex;
      [FieldOffset(4)]
      public int Count;
      [FieldOffset(8)]
      public long TotalSize;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1648664, XrefRangeEnd = 1648665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(NativeMemoryAnalysis.ComponentDump other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.ComponentDump.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ComponentDump_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ComponentDump()
      {
        Il2CppClassPointerStore<NativeMemoryAnalysis.ComponentDump>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (ComponentDump));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryAnalysis.ComponentDump>.NativeClassPtr);
        NativeMemoryAnalysis.ComponentDump.NativeFieldInfoPtr_ComponentTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.ComponentDump>.NativeClassPtr, nameof (ComponentTypeIndex));
        NativeMemoryAnalysis.ComponentDump.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.ComponentDump>.NativeClassPtr, nameof (Count));
        NativeMemoryAnalysis.ComponentDump.NativeFieldInfoPtr_TotalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.ComponentDump>.NativeClassPtr, nameof (TotalSize));
        NativeMemoryAnalysis.ComponentDump.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ComponentDump_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis.ComponentDump>.NativeClassPtr, 100663823);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeMemoryAnalysis.ComponentDump>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class Item : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CollectionType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Size;
      private static readonly System.IntPtr NativeFieldInfoPtr_Info;
      private static readonly System.IntPtr NativeFieldInfoPtr_MemoryAllocationPtr;
      private static readonly System.IntPtr NativeFieldInfoPtr_References;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Int32_String_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AppendCollectionType_Public_Void_StringBuilder_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1648696, RefRangeEnd = 1648698, XrefRangeStart = 1648672, XrefRangeEnd = 1648696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Item(FieldInfo rootField, int size, string info, System.IntPtr memoryAllocationPtr)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootField);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(info);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &memoryAllocationPtr;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.Item.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Int32_String_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1648741, RefRangeEnd = 1648744, XrefRangeStart = 1648698, XrefRangeEnd = 1648741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AppendCollectionType(StringBuilder stringBuilder)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.Item.NativeMethodInfoPtr_AppendCollectionType_Public_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Item()
      {
        Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMemoryAnalysis>.NativeClassPtr, nameof (Item));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr);
        NativeMemoryAnalysis.Item.NativeFieldInfoPtr_CollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, nameof (CollectionType));
        NativeMemoryAnalysis.Item.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, nameof (Size));
        NativeMemoryAnalysis.Item.NativeFieldInfoPtr_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, nameof (Info));
        NativeMemoryAnalysis.Item.NativeFieldInfoPtr_MemoryAllocationPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, nameof (MemoryAllocationPtr));
        NativeMemoryAnalysis.Item.NativeFieldInfoPtr_References = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, nameof (References));
        NativeMemoryAnalysis.Item.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Int32_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, 100663824);
        NativeMemoryAnalysis.Item.NativeMethodInfoPtr_AppendCollectionType_Public_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, 100663825);
      }

      public Item(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Type CollectionType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_CollectionType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_CollectionType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Size
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_Size));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_Size)) = value;
        }
      }

      public unsafe string Info
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_Info)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_Info), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe System.IntPtr MemoryAllocationPtr
      {
        get
        {
          return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_MemoryAllocationPtr));
        }
        [param: In] set
        {
          *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_MemoryAllocationPtr)) = value;
        }
      }

      public unsafe List<NativeMemoryAnalysis.Item.ItemReference> References
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_References));
          return pointer == System.IntPtr.Zero ? (List<NativeMemoryAnalysis.Item.ItemReference>) null : new List<NativeMemoryAnalysis.Item.ItemReference>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.NativeFieldInfoPtr_References), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public class ItemReference : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_RootField;
        private static readonly System.IntPtr NativeFieldInfoPtr_PathBuilder;
        private static readonly System.IntPtr NativeMethodInfoPtr_AddToPath_Public_Void_String_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1648670, RefRangeEnd = 1648672, XrefRangeStart = 1648665, XrefRangeEnd = 1648670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void AddToPath(string s)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(s);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.Item.ItemReference.NativeMethodInfoPtr_AddToPath_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(3875)]
        [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ItemReference()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMemoryAnalysis.Item.ItemReference>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(NativeMemoryAnalysis.Item.ItemReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ItemReference()
        {
          Il2CppClassPointerStore<NativeMemoryAnalysis.Item.ItemReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeMemoryAnalysis.Item>.NativeClassPtr, nameof (ItemReference));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryAnalysis.Item.ItemReference>.NativeClassPtr);
          NativeMemoryAnalysis.Item.ItemReference.NativeFieldInfoPtr_RootField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.Item.ItemReference>.NativeClassPtr, nameof (RootField));
          NativeMemoryAnalysis.Item.ItemReference.NativeFieldInfoPtr_PathBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryAnalysis.Item.ItemReference>.NativeClassPtr, nameof (PathBuilder));
          NativeMemoryAnalysis.Item.ItemReference.NativeMethodInfoPtr_AddToPath_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis.Item.ItemReference>.NativeClassPtr, 100663826);
          NativeMemoryAnalysis.Item.ItemReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryAnalysis.Item.ItemReference>.NativeClassPtr, 100663827);
        }

        public ItemReference(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public unsafe FieldInfo RootField
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.ItemReference.NativeFieldInfoPtr_RootField));
            return pointer == System.IntPtr.Zero ? (FieldInfo) null : new FieldInfo(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.ItemReference.NativeFieldInfoPtr_RootField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe StringBuilder PathBuilder
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.ItemReference.NativeFieldInfoPtr_PathBuilder));
            return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NativeMemoryAnalysis.Item.ItemReference.NativeFieldInfoPtr_PathBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }
    }
  }
}
