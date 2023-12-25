// Decompiled with JetBrains decompiler
// Type: ProjectM.GiveItemCommandUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class GiveItemCommandUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GuidPrefix;
    private static readonly System.IntPtr NativeMethodInfoPtr_GeneratePrefabParameterString_Public_Static_String_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParsePrefabGUIDParamSuffix_Public_Static_Boolean_String_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunGiveItemCommand_Public_Static_Void_PrefabGUID_Int32_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllGiveableItems_Public_Static_Void_EntityManager_UserContentFlags_NativeHashSet_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllGiveableItems_Public_Static_Void_EntityManager_UserContentFlags_NativeHashMap_2_PrefabGUID_DropTableData_NativeHashMap_2_PrefabGUID_RecipeData_NativeArray_1_PrefabGUID_PrefabLookupMap_NativeHashSet_1_PrefabGUID_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1044252, RefRangeEnd = 1044254, XrefRangeStart = 1044242, XrefRangeEnd = 1044252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GeneratePrefabParameterString(
      PrefabGUID prefabGuid,
      bool surroundWithCitationMarks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &surroundWithCitationMarks;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GiveItemCommandUtility.NativeMethodInfoPtr_GeneratePrefabParameterString_Public_Static_String_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044261, RefRangeEnd = 1044262, XrefRangeStart = 1044254, XrefRangeEnd = 1044261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryParsePrefabGUIDParamSuffix(
      string paramText,
      out PrefabGUID prefabGUID)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(paramText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GiveItemCommandUtility.NativeMethodInfoPtr_TryParsePrefabGUIDParamSuffix_Public_Static_Boolean_String_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044286, RefRangeEnd = 1044287, XrefRangeStart = 1044262, XrefRangeEnd = 1044286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunGiveItemCommand(
      PrefabGUID prefabGuid,
      int amount,
      bool showInConsole,
      string optionalName = "")
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &showInConsole;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(optionalName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveItemCommandUtility.NativeMethodInfoPtr_RunGiveItemCommand_Public_Static_Void_PrefabGUID_Int32_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044319, RefRangeEnd = 1044320, XrefRangeStart = 1044287, XrefRangeEnd = 1044319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllGiveableItems(
      EntityManager entityManager,
      UserContentFlags userContentFlags,
      NativeHashSet<PrefabGUID> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveItemCommandUtility.NativeMethodInfoPtr_GetAllGiveableItems_Public_Static_Void_EntityManager_UserContentFlags_NativeHashSet_1_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1044462, RefRangeEnd = 1044464, XrefRangeStart = 1044320, XrefRangeEnd = 1044462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllGiveableItems(
      EntityManager entityManager,
      UserContentFlags userContentFlags,
      NativeHashMap<PrefabGUID, DropTableData> dropTableDataHashLookupMap,
      NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap,
      NativeArray<PrefabGUID> legendaryWeapons,
      PrefabLookupMap prefabLookupMap,
      NativeHashSet<PrefabGUID> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dropTableDataHashLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeHashLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &legendaryWeapons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GiveItemCommandUtility.NativeMethodInfoPtr_GetAllGiveableItems_Public_Static_Void_EntityManager_UserContentFlags_NativeHashMap_2_PrefabGUID_DropTableData_NativeHashMap_2_PrefabGUID_RecipeData_NativeArray_1_PrefabGUID_PrefabLookupMap_NativeHashSet_1_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GiveItemCommandUtility()
    {
      Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GiveItemCommandUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr);
      GiveItemCommandUtility.NativeFieldInfoPtr_GuidPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr, nameof (GuidPrefix));
      GiveItemCommandUtility.NativeMethodInfoPtr_GeneratePrefabParameterString_Public_Static_String_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr, 100681832);
      GiveItemCommandUtility.NativeMethodInfoPtr_TryParsePrefabGUIDParamSuffix_Public_Static_Boolean_String_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr, 100681833);
      GiveItemCommandUtility.NativeMethodInfoPtr_RunGiveItemCommand_Public_Static_Void_PrefabGUID_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr, 100681834);
      GiveItemCommandUtility.NativeMethodInfoPtr_GetAllGiveableItems_Public_Static_Void_EntityManager_UserContentFlags_NativeHashSet_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr, 100681835);
      GiveItemCommandUtility.NativeMethodInfoPtr_GetAllGiveableItems_Public_Static_Void_EntityManager_UserContentFlags_NativeHashMap_2_PrefabGUID_DropTableData_NativeHashMap_2_PrefabGUID_RecipeData_NativeArray_1_PrefabGUID_PrefabLookupMap_NativeHashSet_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveItemCommandUtility>.NativeClassPtr, 100681836);
    }

    public GiveItemCommandUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string GuidPrefix
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GiveItemCommandUtility.NativeFieldInfoPtr_GuidPrefix, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GiveItemCommandUtility.NativeFieldInfoPtr_GuidPrefix, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
