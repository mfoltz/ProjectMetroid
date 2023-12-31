// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemDataDropGroupBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ItemDataDropGroupBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropItemPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public PrefabGUID DropItemPrefab;
    [FieldOffset(12)]
    public int Quantity;
    [FieldOffset(16)]
    public int Weight;
    [FieldOffset(20)]
    public DropItemType Type;

    static ItemDataDropGroupBuffer()
    {
      Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ItemDataDropGroupBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr);
      ItemDataDropGroupBuffer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr, nameof (Entity));
      ItemDataDropGroupBuffer.NativeFieldInfoPtr_DropItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr, nameof (DropItemPrefab));
      ItemDataDropGroupBuffer.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr, nameof (Quantity));
      ItemDataDropGroupBuffer.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr, nameof (Weight));
      ItemDataDropGroupBuffer.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr, nameof (Type));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemDataDropGroupBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
