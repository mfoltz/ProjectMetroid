// Decompiled with JetBrains decompiler
// Type: ProjectM.BuildMenuPlacementOperation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class BuildMenuPlacementOperation : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastPlacementOperation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPlacementResult;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeepPlacementResultForNextFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleTargetBlocked;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNewPlacementResult_Public_Void_Operation_PlacementResult_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAtFrameStart_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001357, XrefRangeEnd = 1001358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuPlacementOperation.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1001359, RefRangeEnd = 1001360, XrefRangeStart = 1001358, XrefRangeEnd = 1001359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetNewPlacementResult(
      GetPlacementResult.Operation operation,
      PlacementResult result,
      bool dismantleBlocked,
      bool keepResultAtEndOfFrame,
      bool keepOldResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &operation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dismantleBlocked;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &keepResultAtEndOfFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &keepOldResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuPlacementOperation.NativeMethodInfoPtr_SetNewPlacementResult_Public_Void_Operation_PlacementResult_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1001361, RefRangeEnd = 1001363, XrefRangeStart = 1001360, XrefRangeEnd = 1001361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAtFrameStart()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuPlacementOperation.NativeMethodInfoPtr_UpdateAtFrameStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenuPlacementOperation()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuPlacementOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenuPlacementOperation()
    {
      Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BuildMenuPlacementOperation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr);
      BuildMenuPlacementOperation.NativeFieldInfoPtr_LastPlacementOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, nameof (LastPlacementOperation));
      BuildMenuPlacementOperation.NativeFieldInfoPtr_CurrentPlacementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, nameof (CurrentPlacementResult));
      BuildMenuPlacementOperation.NativeFieldInfoPtr_KeepPlacementResultForNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, nameof (KeepPlacementResultForNextFrame));
      BuildMenuPlacementOperation.NativeFieldInfoPtr_DismantleTargetBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, nameof (DismantleTargetBlocked));
      BuildMenuPlacementOperation.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, 100677509);
      BuildMenuPlacementOperation.NativeMethodInfoPtr_SetNewPlacementResult_Public_Void_Operation_PlacementResult_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, 100677510);
      BuildMenuPlacementOperation.NativeMethodInfoPtr_UpdateAtFrameStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, 100677511);
      BuildMenuPlacementOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuPlacementOperation>.NativeClassPtr, 100677512);
    }

    public BuildMenuPlacementOperation(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GetPlacementResult.Operation LastPlacementOperation
    {
      get
      {
        return *(GetPlacementResult.Operation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_LastPlacementOperation));
      }
      [param: In] set
      {
        *(GetPlacementResult.Operation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_LastPlacementOperation)) = value;
      }
    }

    public unsafe PlacementResult CurrentPlacementResult
    {
      get
      {
        return *(PlacementResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_CurrentPlacementResult));
      }
      [param: In] set
      {
        *(PlacementResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_CurrentPlacementResult)) = value;
      }
    }

    public unsafe bool KeepPlacementResultForNextFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_KeepPlacementResultForNextFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_KeepPlacementResultForNextFrame)) = value;
      }
    }

    public unsafe bool DismantleTargetBlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_DismantleTargetBlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuPlacementOperation.NativeFieldInfoPtr_DismantleTargetBlocked)) = value;
      }
    }
  }
}
