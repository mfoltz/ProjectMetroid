// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.PlacementEntityId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementEntityId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ExistingEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateTileModelDataIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromExistingEntity_Public_Static_PlacementEntityId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromNewEntity_Public_Static_PlacementEntityId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromNewOrExistingEntity_Public_Static_PlacementEntityId_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlacementEntityId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public Entity ExistingEntity;
    [FieldOffset(8)]
    public Nullable_Unboxed<int> CreateTileModelDataIndex;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794450, RefRangeEnd = 794453, XrefRangeStart = 794450, XrefRangeEnd = 794450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementEntityId FromExistingEntity(Entity entityId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementEntityId.NativeMethodInfoPtr_FromExistingEntity_Public_Static_PlacementEntityId_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementEntityId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794457, RefRangeEnd = 794458, XrefRangeStart = 794453, XrefRangeEnd = 794457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementEntityId FromNewEntity(int createTileModelDataIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &createTileModelDataIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementEntityId.NativeMethodInfoPtr_FromNewEntity_Public_Static_PlacementEntityId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementEntityId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794464, RefRangeEnd = 794467, XrefRangeStart = 794458, XrefRangeEnd = 794464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementEntityId FromNewOrExistingEntity(
      int createTileModelDataIndex,
      Entity entityId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &createTileModelDataIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementEntityId.NativeMethodInfoPtr_FromNewOrExistingEntity_Public_Static_PlacementEntityId_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementEntityId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794467, XrefRangeEnd = 794470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(PlacementEntityId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementEntityId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlacementEntityId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794470, XrefRangeEnd = 794484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlacementEntityId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PlacementEntityId()
    {
      Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (PlacementEntityId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr);
      PlacementEntityId.NativeFieldInfoPtr_ExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, nameof (ExistingEntity));
      PlacementEntityId.NativeFieldInfoPtr_CreateTileModelDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, nameof (CreateTileModelDataIndex));
      PlacementEntityId.NativeMethodInfoPtr_FromExistingEntity_Public_Static_PlacementEntityId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, 100670049);
      PlacementEntityId.NativeMethodInfoPtr_FromNewEntity_Public_Static_PlacementEntityId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, 100670050);
      PlacementEntityId.NativeMethodInfoPtr_FromNewOrExistingEntity_Public_Static_PlacementEntityId_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, 100670051);
      PlacementEntityId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlacementEntityId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, 100670052);
      PlacementEntityId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, 100670053);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementEntityId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
