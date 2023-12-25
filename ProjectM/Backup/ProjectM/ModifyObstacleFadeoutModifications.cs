// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyObstacleFadeoutModifications
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyObstacleFadeoutModifications
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EnabledModificationId;
    [FieldOffset(0)]
    public ModificationId EnabledModificationId;

    static ModifyObstacleFadeoutModifications()
    {
      Il2CppClassPointerStore<ModifyObstacleFadeoutModifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyObstacleFadeoutModifications));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyObstacleFadeoutModifications>.NativeClassPtr);
      ModifyObstacleFadeoutModifications.NativeFieldInfoPtr_EnabledModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyObstacleFadeoutModifications>.NativeClassPtr, nameof (EnabledModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyObstacleFadeoutModifications>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
