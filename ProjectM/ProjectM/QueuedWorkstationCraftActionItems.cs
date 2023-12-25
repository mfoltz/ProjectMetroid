// Decompiled with JetBrains decompiler
// Type: ProjectM.QueuedWorkstationCraftActionItems
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct QueuedWorkstationCraftActionItems
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Item;
    [FieldOffset(0)]
    public InventoryBuffer Item;

    static QueuedWorkstationCraftActionItems()
    {
      Il2CppClassPointerStore<QueuedWorkstationCraftActionItems>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (QueuedWorkstationCraftActionItems));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueuedWorkstationCraftActionItems>.NativeClassPtr);
      QueuedWorkstationCraftActionItems.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedWorkstationCraftActionItems>.NativeClassPtr, nameof (Item));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueuedWorkstationCraftActionItems>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
