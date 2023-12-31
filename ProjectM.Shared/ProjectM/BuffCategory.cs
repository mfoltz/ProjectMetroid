// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffCategory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BuffCategory
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_Groups;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeepOldest;
    [FieldOffset(0)]
    public int Level;
    [FieldOffset(8)]
    public BuffCategoryFlag Groups;
    [FieldOffset(16)]
    public bool KeepOldest;

    static BuffCategory()
    {
      Il2CppClassPointerStore<BuffCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffCategory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffCategory>.NativeClassPtr);
      BuffCategory.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCategory>.NativeClassPtr, nameof (Level));
      BuffCategory.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCategory>.NativeClassPtr, nameof (Groups));
      BuffCategory.NativeFieldInfoPtr_KeepOldest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffCategory>.NativeClassPtr, nameof (KeepOldest));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffCategory>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
