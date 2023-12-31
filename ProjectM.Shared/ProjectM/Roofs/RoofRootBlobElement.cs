// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofRootBlobElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoofRootBlobElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VariationStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_VariationCount;
    [FieldOffset(0)]
    public int VariationStart;
    [FieldOffset(4)]
    public int VariationCount;

    static RoofRootBlobElement()
    {
      Il2CppClassPointerStore<RoofRootBlobElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Roofs", nameof (RoofRootBlobElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofRootBlobElement>.NativeClassPtr);
      RoofRootBlobElement.NativeFieldInfoPtr_VariationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofRootBlobElement>.NativeClassPtr, nameof (VariationStart));
      RoofRootBlobElement.NativeFieldInfoPtr_VariationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofRootBlobElement>.NativeClassPtr, nameof (VariationCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofRootBlobElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
