// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.GetEditOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public static class GetEditOptions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ForExistingEntity_Public_Static_Void_EntityManager_Entity_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForExistingEntity_Public_Static_Void_EntityManager_Entity_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1131407, RefRangeEnd = 1131411, XrefRangeStart = 1131406, XrefRangeEnd = 1131407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ForExistingEntity(
      EntityManager entityManager,
      Entity existingEntity,
      out bool canMove,
      out bool canRotate,
      out bool canDismantle,
      out bool canRepair)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &existingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref canMove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref canRotate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref canDismantle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref canRepair;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetEditOptions.NativeMethodInfoPtr_ForExistingEntity_Public_Static_Void_EntityManager_Entity_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1131483, RefRangeEnd = 1131485, XrefRangeStart = 1131411, XrefRangeEnd = 1131483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ForExistingEntity(
      EntityManager entityManager,
      Entity existingEntity,
      out bool canMove,
      out bool canRotate,
      out bool canDismantle,
      out bool canRepair,
      out bool forceIncludeBuildError)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &existingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref canMove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref canRotate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref canDismantle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref canRepair;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref forceIncludeBuildError;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetEditOptions.NativeMethodInfoPtr_ForExistingEntity_Public_Static_Void_EntityManager_Entity_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetEditOptions()
    {
      Il2CppClassPointerStore<GetEditOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (GetEditOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetEditOptions>.NativeClassPtr);
      GetEditOptions.NativeMethodInfoPtr_ForExistingEntity_Public_Static_Void_EntityManager_Entity_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetEditOptions>.NativeClassPtr, 100689824);
      GetEditOptions.NativeMethodInfoPtr_ForExistingEntity_Public_Static_Void_EntityManager_Entity_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetEditOptions>.NativeClassPtr, 100689825);
    }

    public GetEditOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
