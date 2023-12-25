// Decompiled with JetBrains decompiler
// Type: ProjectM.ProgressionBookShapeshiftElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProgressionBookShapeshiftElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Shapeshift;
    [FieldOffset(0)]
    public PrefabGUID Shapeshift;

    static ProgressionBookShapeshiftElement()
    {
      Il2CppClassPointerStore<ProgressionBookShapeshiftElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProgressionBookShapeshiftElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionBookShapeshiftElement>.NativeClassPtr);
      ProgressionBookShapeshiftElement.NativeFieldInfoPtr_Shapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionBookShapeshiftElement>.NativeClassPtr, nameof (Shapeshift));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProgressionBookShapeshiftElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
