// Decompiled with JetBrains decompiler
// Type: ProjectM.UseBossCenterPositionAsPreCombatPosition
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UseBossCenterPositionAsPreCombatPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RangeSq;
    private static readonly System.IntPtr NativeFieldInfoPtr_Found;
    [FieldOffset(0)]
    public float RangeSq;
    [FieldOffset(4)]
    public bool Found;

    static UseBossCenterPositionAsPreCombatPosition()
    {
      Il2CppClassPointerStore<UseBossCenterPositionAsPreCombatPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UseBossCenterPositionAsPreCombatPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseBossCenterPositionAsPreCombatPosition>.NativeClassPtr);
      UseBossCenterPositionAsPreCombatPosition.NativeFieldInfoPtr_RangeSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBossCenterPositionAsPreCombatPosition>.NativeClassPtr, nameof (RangeSq));
      UseBossCenterPositionAsPreCombatPosition.NativeFieldInfoPtr_Found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBossCenterPositionAsPreCombatPosition>.NativeClassPtr, nameof (Found));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UseBossCenterPositionAsPreCombatPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
