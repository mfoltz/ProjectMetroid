// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConeRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConeAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_NightFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroValue;
    [FieldOffset(0)]
    public float ConeRadius;
    [FieldOffset(4)]
    public float ConeAngle;
    [FieldOffset(8)]
    public float CircleRadius;
    [FieldOffset(12)]
    public float NightFactor;
    [FieldOffset(16)]
    public float AggroValue;

    static AggroData()
    {
      Il2CppClassPointerStore<AggroData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroData>.NativeClassPtr);
      AggroData.NativeFieldInfoPtr_ConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroData>.NativeClassPtr, nameof (ConeRadius));
      AggroData.NativeFieldInfoPtr_ConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroData>.NativeClassPtr, nameof (ConeAngle));
      AggroData.NativeFieldInfoPtr_CircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroData>.NativeClassPtr, nameof (CircleRadius));
      AggroData.NativeFieldInfoPtr_NightFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroData>.NativeClassPtr, nameof (NightFactor));
      AggroData.NativeFieldInfoPtr_AggroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroData>.NativeClassPtr, nameof (AggroValue));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
