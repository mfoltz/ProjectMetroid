// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionCooldown
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastOptionCooldown
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    [FieldOffset(0)]
    public float Min;
    [FieldOffset(4)]
    public float Max;

    static CastOptionCooldown()
    {
      Il2CppClassPointerStore<CastOptionCooldown>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionCooldown));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCooldown>.NativeClassPtr);
      CastOptionCooldown.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCooldown>.NativeClassPtr, nameof (Min));
      CastOptionCooldown.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCooldown>.NativeClassPtr, nameof (Max));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCooldown>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
