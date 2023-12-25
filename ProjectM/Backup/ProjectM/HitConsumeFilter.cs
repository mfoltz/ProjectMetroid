// Decompiled with JetBrains decompiler
// Type: ProjectM.HitConsumeFilter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HitConsumeFilter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TeamFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellFilter;
    [FieldOffset(0)]
    public TeamFilterEnum TeamFilter;
    [FieldOffset(4)]
    public SpellFilterEnum SpellFilter;

    static HitConsumeFilter()
    {
      Il2CppClassPointerStore<HitConsumeFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HitConsumeFilter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitConsumeFilter>.NativeClassPtr);
      HitConsumeFilter.NativeFieldInfoPtr_TeamFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitConsumeFilter>.NativeClassPtr, nameof (TeamFilter));
      HitConsumeFilter.NativeFieldInfoPtr_SpellFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitConsumeFilter>.NativeClassPtr, nameof (SpellFilter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitConsumeFilter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
