// Decompiled with JetBrains decompiler
// Type: ProjectM.DropItemInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DropItemInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    [FieldOffset(0)]
    public PrefabGUID ItemGuid;
    [FieldOffset(4)]
    public int Quantity;
    [FieldOffset(8)]
    public DropItemType Type;
    [FieldOffset(12)]
    public int Level;

    static DropItemInfo()
    {
      Il2CppClassPointerStore<DropItemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropItemInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemInfo>.NativeClassPtr);
      DropItemInfo.NativeFieldInfoPtr_ItemGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemInfo>.NativeClassPtr, nameof (ItemGuid));
      DropItemInfo.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemInfo>.NativeClassPtr, nameof (Quantity));
      DropItemInfo.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemInfo>.NativeClassPtr, nameof (Type));
      DropItemInfo.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemInfo>.NativeClassPtr, nameof (Level));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
