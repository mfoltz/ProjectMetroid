// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UIHighlightHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class UIHighlightHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewKilledVBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_CACHE_DIR;
    private static readonly System.IntPtr NativeFieldInfoPtr__HighlightData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SessionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Instance;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasKilledNewVBlood_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearNewKilledVBlood_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CacheDir_Private_Static_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HighlightData_Public_get_UIHighlightData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HighlightData_Private_set_Void_UIHighlightData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_UIHighlightHelper_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAllAbilitiesUnlocked_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAbilitiesUnlocked_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilitiesUnlocked_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAbilitiesUnlocked_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetShapeShiftsUnlocked_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShapeShiftsUnlocked_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBuildingViewed_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIsBuildingViewed_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRecipeViewed_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIsRecipeViewed_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddResearchViewed_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIsResearchViewed_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddVBloodViewed_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIsVBloodViewed_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIsAbilityViewed_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnseenAbilities_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAbilityViewed_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIsShapeShiftViewed_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnseenShapeShifts_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddShapeShiftViewed_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Save_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public static unsafe bool HasKilledNewVBlood
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1289010, RefRangeEnd = 1289011, XrefRangeStart = 1289004, XrefRangeEnd = 1289010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_get_HasKilledNewVBlood_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289015, RefRangeEnd = 1289016, XrefRangeStart = 1289011, XrefRangeEnd = 1289015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearNewKilledVBlood()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_ClearNewKilledVBlood_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public static unsafe string CacheDir
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 1289023, RefRangeEnd = 1289027, XrefRangeStart = 1289016, XrefRangeEnd = 1289023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_get_CacheDir_Private_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe UIHighlightData HighlightData
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_get_HighlightData_Public_get_UIHighlightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UIHighlightData) null : new UIHighlightData(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_set_HighlightData_Private_set_Void_UIHighlightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1289081, RefRangeEnd = 1289096, XrefRangeStart = 1289027, XrefRangeEnd = 1289081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe UIHighlightHelper Load(string sessionId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sessionId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_Load_Public_Static_UIHighlightHelper_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289096, XrefRangeEnd = 1289117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_Clear_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1289118, RefRangeEnd = 1289120, XrefRangeStart = 1289117, XrefRangeEnd = 1289118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAllAbilitiesUnlocked(int count)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_SetAllAbilitiesUnlocked_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289120, RefRangeEnd = 1289121, XrefRangeStart = 1289120, XrefRangeEnd = 1289120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetAllAbilitiesUnlocked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetAllAbilitiesUnlocked_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289122, RefRangeEnd = 1289123, XrefRangeStart = 1289121, XrefRangeEnd = 1289122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAbilitiesUnlocked(int count)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_SetAbilitiesUnlocked_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int GetAbilitiesUnlocked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetAbilitiesUnlocked_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289124, RefRangeEnd = 1289125, XrefRangeStart = 1289123, XrefRangeEnd = 1289124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetShapeShiftsUnlocked(int count)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_SetShapeShiftsUnlocked_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 445142, RefRangeEnd = 445150, XrefRangeStart = 445142, XrefRangeEnd = 445150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetShapeShiftsUnlocked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetShapeShiftsUnlocked_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289132, RefRangeEnd = 1289133, XrefRangeStart = 1289125, XrefRangeEnd = 1289132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddBuildingViewed(int buildingId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &buildingId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_AddBuildingViewed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289137, RefRangeEnd = 1289138, XrefRangeStart = 1289133, XrefRangeEnd = 1289137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetIsBuildingViewed(int buildingId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &buildingId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetIsBuildingViewed_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1289145, RefRangeEnd = 1289150, XrefRangeStart = 1289138, XrefRangeEnd = 1289145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddRecipeViewed(int recipeId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &recipeId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_AddRecipeViewed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289154, RefRangeEnd = 1289155, XrefRangeStart = 1289150, XrefRangeEnd = 1289154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetIsRecipeViewed(int recipeId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &recipeId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetIsRecipeViewed_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289162, RefRangeEnd = 1289163, XrefRangeStart = 1289155, XrefRangeEnd = 1289162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddResearchViewed(int researchId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &researchId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_AddResearchViewed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289167, RefRangeEnd = 1289168, XrefRangeStart = 1289163, XrefRangeEnd = 1289167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetIsResearchViewed(int researchId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &researchId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetIsResearchViewed_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289175, RefRangeEnd = 1289176, XrefRangeStart = 1289168, XrefRangeEnd = 1289175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddVBloodViewed(int vBloodId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &vBloodId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_AddVBloodViewed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1289180, RefRangeEnd = 1289184, XrefRangeStart = 1289176, XrefRangeEnd = 1289180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetIsVBloodViewed(int vBloodId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &vBloodId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetIsVBloodViewed_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1289188, RefRangeEnd = 1289191, XrefRangeStart = 1289184, XrefRangeEnd = 1289188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetIsAbilityViewed(int abilityId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &abilityId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetIsAbilityViewed_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1289222, RefRangeEnd = 1289223, XrefRangeStart = 1289191, XrefRangeEnd = 1289222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasUnseenAbilities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_HasUnseenAbilities_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1289230, RefRangeEnd = 1289234, XrefRangeStart = 1289223, XrefRangeEnd = 1289230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddAbilityViewed(int abilityId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &abilityId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_AddAbilityViewed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289234, XrefRangeEnd = 1289238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetIsShapeShiftViewed(int shapeShiftId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &shapeShiftId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_GetIsShapeShiftViewed_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289238, XrefRangeEnd = 1289269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasUnseenShapeShifts()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_HasUnseenShapeShifts_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289269, XrefRangeEnd = 1289276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddShapeShiftViewed(int shapeShiftId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &shapeShiftId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_AddShapeShiftViewed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1289312, RefRangeEnd = 1289323, XrefRangeStart = 1289276, XrefRangeEnd = 1289312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Save()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIHighlightHelper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHighlightHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIHighlightHelper()
    {
      Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UIHighlightHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr);
      UIHighlightHelper.NativeFieldInfoPtr_NewKilledVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, nameof (NewKilledVBlood));
      UIHighlightHelper.NativeFieldInfoPtr_CACHE_DIR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, nameof (CACHE_DIR));
      UIHighlightHelper.NativeFieldInfoPtr__HighlightData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, "<HighlightData>k__BackingField");
      UIHighlightHelper.NativeFieldInfoPtr__SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, nameof (_SessionId));
      UIHighlightHelper.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, nameof (Instance));
      UIHighlightHelper.NativeMethodInfoPtr_get_HasKilledNewVBlood_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669724);
      UIHighlightHelper.NativeMethodInfoPtr_ClearNewKilledVBlood_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669725);
      UIHighlightHelper.NativeMethodInfoPtr_get_CacheDir_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669726);
      UIHighlightHelper.NativeMethodInfoPtr_get_HighlightData_Public_get_UIHighlightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669727);
      UIHighlightHelper.NativeMethodInfoPtr_set_HighlightData_Private_set_Void_UIHighlightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669728);
      UIHighlightHelper.NativeMethodInfoPtr_Load_Public_Static_UIHighlightHelper_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669729);
      UIHighlightHelper.NativeMethodInfoPtr_Clear_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669730);
      UIHighlightHelper.NativeMethodInfoPtr_SetAllAbilitiesUnlocked_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669731);
      UIHighlightHelper.NativeMethodInfoPtr_GetAllAbilitiesUnlocked_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669732);
      UIHighlightHelper.NativeMethodInfoPtr_SetAbilitiesUnlocked_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669733);
      UIHighlightHelper.NativeMethodInfoPtr_GetAbilitiesUnlocked_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669734);
      UIHighlightHelper.NativeMethodInfoPtr_SetShapeShiftsUnlocked_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669735);
      UIHighlightHelper.NativeMethodInfoPtr_GetShapeShiftsUnlocked_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669736);
      UIHighlightHelper.NativeMethodInfoPtr_AddBuildingViewed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669737);
      UIHighlightHelper.NativeMethodInfoPtr_GetIsBuildingViewed_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669738);
      UIHighlightHelper.NativeMethodInfoPtr_AddRecipeViewed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669739);
      UIHighlightHelper.NativeMethodInfoPtr_GetIsRecipeViewed_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669740);
      UIHighlightHelper.NativeMethodInfoPtr_AddResearchViewed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669741);
      UIHighlightHelper.NativeMethodInfoPtr_GetIsResearchViewed_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669742);
      UIHighlightHelper.NativeMethodInfoPtr_AddVBloodViewed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669743);
      UIHighlightHelper.NativeMethodInfoPtr_GetIsVBloodViewed_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669744);
      UIHighlightHelper.NativeMethodInfoPtr_GetIsAbilityViewed_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669745);
      UIHighlightHelper.NativeMethodInfoPtr_HasUnseenAbilities_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669746);
      UIHighlightHelper.NativeMethodInfoPtr_AddAbilityViewed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669747);
      UIHighlightHelper.NativeMethodInfoPtr_GetIsShapeShiftViewed_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669748);
      UIHighlightHelper.NativeMethodInfoPtr_HasUnseenShapeShifts_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669749);
      UIHighlightHelper.NativeMethodInfoPtr_AddShapeShiftViewed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669750);
      UIHighlightHelper.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669751);
      UIHighlightHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHighlightHelper>.NativeClassPtr, 100669752);
    }

    public UIHighlightHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe PrefabGUID NewKilledVBlood
    {
      get
      {
        PrefabGUID newKilledVblood;
        IL2CPP.il2cpp_field_static_get_value(UIHighlightHelper.NativeFieldInfoPtr_NewKilledVBlood, (void*) &newKilledVblood);
        return newKilledVblood;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIHighlightHelper.NativeFieldInfoPtr_NewKilledVBlood, (void*) &value);
      }
    }

    public static unsafe string CACHE_DIR
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(UIHighlightHelper.NativeFieldInfoPtr_CACHE_DIR, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIHighlightHelper.NativeFieldInfoPtr_CACHE_DIR, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe UIHighlightData _HighlightData_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightHelper.NativeFieldInfoPtr__HighlightData_k__BackingField));
        return pointer == System.IntPtr.Zero ? (UIHighlightData) null : new UIHighlightData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightHelper.NativeFieldInfoPtr__HighlightData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _SessionId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightHelper.NativeFieldInfoPtr__SessionId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHighlightHelper.NativeFieldInfoPtr__SessionId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe UIHighlightHelper Instance
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UIHighlightHelper.NativeFieldInfoPtr_Instance, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIHighlightHelper.NativeFieldInfoPtr_Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
