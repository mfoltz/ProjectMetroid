// Decompiled with JetBrains decompiler
// Type: ProjectM.ShatteredItem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShatteredItem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputItem;
    [FieldOffset(0)]
    public PrefabGUID RequiredItem;
    [FieldOffset(4)]
    public PrefabGUID OutputItem;

    static ShatteredItem()
    {
      Il2CppClassPointerStore<ShatteredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ShatteredItem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShatteredItem>.NativeClassPtr);
      ShatteredItem.NativeFieldInfoPtr_RequiredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItem>.NativeClassPtr, nameof (RequiredItem));
      ShatteredItem.NativeFieldInfoPtr_OutputItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItem>.NativeClassPtr, nameof (OutputItem));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShatteredItem>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
