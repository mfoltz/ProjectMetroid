// Decompiled with JetBrains decompiler
// Type: ProjectM.DismantleAbility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DismantleAbility
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleTarget;
    [FieldOffset(0)]
    public Entity DismantleTarget;

    static DismantleAbility()
    {
      Il2CppClassPointerStore<DismantleAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DismantleAbility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DismantleAbility>.NativeClassPtr);
      DismantleAbility.NativeFieldInfoPtr_DismantleTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismantleAbility>.NativeClassPtr, nameof (DismantleTarget));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DismantleAbility>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
