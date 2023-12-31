// Decompiled with JetBrains decompiler
// Type: ProjectM.WeaponLevel
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WeaponLevel
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId;
    [FieldOffset(0)]
    public float Level;
    [FieldOffset(4)]
    public ModificationId ModificationId;

    static WeaponLevel()
    {
      Il2CppClassPointerStore<WeaponLevel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WeaponLevel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponLevel>.NativeClassPtr);
      WeaponLevel.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponLevel>.NativeClassPtr, nameof (Level));
      WeaponLevel.NativeFieldInfoPtr_ModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponLevel>.NativeClassPtr, nameof (ModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeaponLevel>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
