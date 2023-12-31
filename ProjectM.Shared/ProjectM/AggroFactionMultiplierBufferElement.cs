// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroFactionMultiplierBufferElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroFactionMultiplierBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Multiplier;
    [FieldOffset(0)]
    public int FactionIndex;
    [FieldOffset(4)]
    public float Multiplier;

    static AggroFactionMultiplierBufferElement()
    {
      Il2CppClassPointerStore<AggroFactionMultiplierBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroFactionMultiplierBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroFactionMultiplierBufferElement>.NativeClassPtr);
      AggroFactionMultiplierBufferElement.NativeFieldInfoPtr_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroFactionMultiplierBufferElement>.NativeClassPtr, nameof (FactionIndex));
      AggroFactionMultiplierBufferElement.NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroFactionMultiplierBufferElement>.NativeClassPtr, nameof (Multiplier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroFactionMultiplierBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
