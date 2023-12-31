// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofCategory
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoofCategory
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    [FieldOffset(0)]
    public RoofCategoryType Category;

    static RoofCategory()
    {
      Il2CppClassPointerStore<RoofCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Roofs", nameof (RoofCategory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofCategory>.NativeClassPtr);
      RoofCategory.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofCategory>.NativeClassPtr, nameof (Category));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofCategory>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
