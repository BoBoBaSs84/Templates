using GTA;
using GTA.Math;

namespace DomainName.Application.Abstractions.Application.Providers;

/// <summary>
/// Represents an abstraction contract for the <see cref="Audio"/> class.
/// </summary>
public interface IAudioProvider
{
	/// <inheritdoc cref="Audio.PlayMusic(string)"/>
	void PlayMusic(string musicFile);

	/// <inheritdoc cref="Audio.StopMusic(string)"/>
	void StopMusic(string musicFile);

	/// <inheritdoc cref="Audio.PlaySoundAt(Entity, string)"/>
	int PlaySoundAt(Entity entity, string soundFile);

	/// <inheritdoc cref="Audio.PlaySoundAt(Entity, string, string)"/>
	int PlaySoundAt(Entity entity, string soundFile, string soundSet);

	/// <inheritdoc cref="Audio.PlaySoundAt(Vector3, string)"/>
	int PlaySoundAt(Vector3 position, string soundFile);

	/// <inheritdoc cref="Audio.PlaySoundAt(Vector3, string, string)"/>
	int PlaySoundAt(Vector3 position, string soundFile, string soundSet);

	/// <inheritdoc cref="Audio.PlaySoundFrontend(string)"/>
	int PlaySoundFrontend(string soundFile);

	/// <inheritdoc cref="Audio.PlaySoundFrontend(string, string)"/>
	int PlaySoundFrontend(string soundFile, string soundSet);

	/// <inheritdoc cref="Audio.StopSound(int)"/>
	void StopSound(int id);

	/// <inheritdoc cref="Audio.ReleaseSound(int)"/>
	void ReleaseSound(int id);

	/// <inheritdoc cref="Audio.HasSoundFinished(int)"/>
	bool HasSoundFinished(int id);

	/// <inheritdoc cref="Audio.SetAudioFlag(AudioFlags, bool)"/>
	void SetAudioFlag(AudioFlags flag, bool toggle);
}
