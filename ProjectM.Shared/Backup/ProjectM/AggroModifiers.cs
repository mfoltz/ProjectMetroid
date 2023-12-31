// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroModifiers
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroModifiers
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConeRadiusFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleRadiusFactor;
    [FieldOffset(0)]
    public ModifiableFloat ConeRadiusFactor;
    [FieldOffset(8)]
    public ModifiableFloat CircleRadiusFactor;

    static AggroModifiers()
    {
      Il2CppClassPointerStore<AggroModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroModifiers>.NativeClassPtr);
      AggroModifiers.NativeFieldInfoPtr_ConeRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroModifiers>.NativeClassPtr, nameof (ConeRadiusFactor));
      AggroModifiers.NativeFieldInfoPtr_CircleRadiusFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroModifiers>.NativeClassPtr, nameof (CircleRadiusFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroModifiers>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
