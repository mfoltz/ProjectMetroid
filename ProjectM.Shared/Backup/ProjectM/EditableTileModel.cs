// Decompiled with JetBrains decompiler
// Type: ProjectM.EditableTileModel
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EditableTileModel
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentEditor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaceAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsEdited;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDismantling;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsRepairing;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanRotateDuringBuild;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanMoveAfterBuild;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanRotateAfterBuild;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanDismantle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanRepair;
    [FieldOffset(0)]
    public NetworkedEntity CurrentEditor;
    [FieldOffset(12)]
    public PrefabGUID DismantleAbility;
    [FieldOffset(16)]
    public PrefabGUID PlaceAbility;
    [FieldOffset(20)]
    public PrefabGUID RepairAbility;
    [FieldOffset(24)]
    public bool IsEdited;
    [FieldOffset(25)]
    public bool IsDismantling;
    [FieldOffset(26)]
    public bool IsRepairing;
    [FieldOffset(27)]
    public bool CanRotateDuringBuild;
    [FieldOffset(28)]
    public bool CanMoveAfterBuild;
    [FieldOffset(29)]
    public bool CanRotateAfterBuild;
    [FieldOffset(30)]
    public bool CanDismantle;
    [FieldOffset(31)]
    public bool CanRepair;

    static EditableTileModel()
    {
      Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EditableTileModel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr);
      EditableTileModel.NativeFieldInfoPtr_CurrentEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (CurrentEditor));
      EditableTileModel.NativeFieldInfoPtr_DismantleAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (DismantleAbility));
      EditableTileModel.NativeFieldInfoPtr_PlaceAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (PlaceAbility));
      EditableTileModel.NativeFieldInfoPtr_RepairAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (RepairAbility));
      EditableTileModel.NativeFieldInfoPtr_IsEdited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (IsEdited));
      EditableTileModel.NativeFieldInfoPtr_IsDismantling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (IsDismantling));
      EditableTileModel.NativeFieldInfoPtr_IsRepairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (IsRepairing));
      EditableTileModel.NativeFieldInfoPtr_CanRotateDuringBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (CanRotateDuringBuild));
      EditableTileModel.NativeFieldInfoPtr_CanMoveAfterBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (CanMoveAfterBuild));
      EditableTileModel.NativeFieldInfoPtr_CanRotateAfterBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (CanRotateAfterBuild));
      EditableTileModel.NativeFieldInfoPtr_CanDismantle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (CanDismantle));
      EditableTileModel.NativeFieldInfoPtr_CanRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, nameof (CanRepair));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EditableTileModel>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
