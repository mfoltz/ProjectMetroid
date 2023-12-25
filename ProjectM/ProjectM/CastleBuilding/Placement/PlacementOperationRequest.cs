// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.PlacementOperationRequest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementOperationRequest
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementOperation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
    [FieldOffset(0)]
    public GetPlacementResult.Operation PlacementOperation;
    [FieldOffset(60)]
    public Entity CallerEntity;
    [FieldOffset(68)]
    public int FunctionHash;

    static PlacementOperationRequest()
    {
      Il2CppClassPointerStore<PlacementOperationRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (PlacementOperationRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementOperationRequest>.NativeClassPtr);
      PlacementOperationRequest.NativeFieldInfoPtr_PlacementOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementOperationRequest>.NativeClassPtr, nameof (PlacementOperation));
      PlacementOperationRequest.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementOperationRequest>.NativeClassPtr, nameof (CallerEntity));
      PlacementOperationRequest.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementOperationRequest>.NativeClassPtr, nameof (FunctionHash));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementOperationRequest>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
